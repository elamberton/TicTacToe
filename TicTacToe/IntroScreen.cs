using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class IntroScreen : Form
    {
        GameForm gameForm;

        public IntroScreen()
        {
            InitializeComponent();
        }

        private void InitGameForm(bool isPlayerO)
        {
            gameForm = new GameForm(isPlayerO);
            gameForm.FormClosed += GameForm_FormClosed;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            InitGameForm(false);
            gameForm.Show();
            this.Visible = false;
        }

        private void OButton_Click(object sender, EventArgs e)
        {
            InitGameForm(true);
            gameForm.Show();
            this.Visible = false;
        }

    }
}
