using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.LogicEngine
{
    public class ComputerPlayer : IPlayer
    {
        private TicTacToeEngine engine;

        public ComputerPlayer(TicTacToeEngine engine)
        {
            this.engine = engine;
        }

        public string Handle 
        { 
            get { return "Computer"; }
            set { }
        }
        public string Team { get; set; }

        public void AlertGameOver(GameStatus gameStatus)
        {
            // Game over. Do nothing.
        }

        public void AlertTurn(GameData gameData)
        {
            // Evaluate the game data and make the next move.
            int suggestedMove = 9;
            int firstAvailableMove = 9;
            char playerChar = gameData.CurrentTurn % 2 == 0 ? 'x' : 'o';
            char opponentChar = playerChar == 'x' ? 'o' : 'x';
            string board = new string(gameData.Board);

            // Check if AI needs to block:
            bool lastMoveTested = false;
            char[] testBoard = new char[9];
            gameData.Board.CopyTo(testBoard, 0);
            bool xInCorner = testBoard[0] == 'x' || testBoard[2] == 'x' || testBoard[6] == 'x' || testBoard[8] == 'x';
            for (int i = 0; i < 9; i++)
            {
                if(lastMoveTested)
                {
                    testBoard[i - 1] = ' ';
                }
                if (testBoard[i] == ' ')
                {
                    if (firstAvailableMove == 9)
                    {
                        firstAvailableMove = i;
                    }
                    lastMoveTested = true;
                    testBoard[i] = opponentChar;
                    if(TicTacToeEngine.IsWin(testBoard))
                    {
                        suggestedMove = i;
                        break;
                    }
                    testBoard[i] = playerChar;
                    if (TicTacToeEngine.IsWin(testBoard))
                    {
                        suggestedMove = i;
                        break;
                    }
                }
                else
                {
                    lastMoveTested = false;
                }
            }
            // Must win or block.
            if(suggestedMove < 9)
            {
                engine.SelectSpace(suggestedMove);
            }
            else if(xInCorner && gameData.CurrentTurn == 1)
            {
                engine.SelectSpace(4);
            }
            else if(gameData.CurrentTurn == 2 && gameData.Board[8] == ' ')
            {
                engine.SelectSpace(8);
            }
            else if (gameData.CurrentTurn == 2 && gameData.Board[2] == ' ')
            {
                engine.SelectSpace(2);
            }
            else
            {
                engine.SelectSpace(firstAvailableMove);
            }
        }
    }
}
