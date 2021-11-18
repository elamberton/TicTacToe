using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.LogicEngine;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class GameForm : Form, IPlayer
    {
        TicTacToeEngine gameEngine;
        public GameForm(bool player)
        {
            InitializeComponent();
            gameEngine = new TicTacToeEngine();
            ComputerPlayer computerPlayer = new ComputerPlayer(gameEngine);
            if(player)
            {
                gameEngine.OPlayer = this;
                gameEngine.XPlayer = computerPlayer;
                computerPlayer.AlertTurn(gameEngine.GetGameData());
            }
            else
            {
                gameEngine.XPlayer = this;
                gameEngine.OPlayer = computerPlayer;
            }
        }

        public string Team { get ; set; }
        string IPlayer.Handle { get; set; }

        public void AlertGameOver(GameStatus gameStatus)
        {
            DrawBoard(gameEngine.GetGameData().Board);
            MessageBox.Show($"{gameStatus}");
            this.Close();
        }

        public void AlertTurn(GameData gameData)
        {
            DrawBoard(gameData.Board);
        }

        private void DrawBoard(char[] board)
        {
            int index;
            foreach (Control control in this.Controls)
            {
                Panel currentPanel = control as Panel;
                if(int.TryParse(control.Tag.ToString(), out index))
                {
                    switch( board[index])
                    {
                        case ' ':
                            currentPanel.BackgroundImage = null;
                            currentPanel.Enabled = true;
                            break;

                        case 'x':
                            currentPanel.BackgroundImage = Resources.XImage;
                            currentPanel.Enabled = false;
                            break;

                        case 'o':
                            currentPanel.BackgroundImage = Resources.OImage;
                            currentPanel.Enabled = false;
                            break;
                    }
                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            try
            {
                Panel clickPanel = sender as Panel;
                if (clickPanel == null)
                {
                    return;
                }
                int move;
                if (!int.TryParse(clickPanel.Tag.ToString(), out move))
                {
                    return;
                }
                gameEngine.SelectSpace(move);
            }
            catch(RuleViolationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"System Error: {ex}");
            }
        }

    }
}
