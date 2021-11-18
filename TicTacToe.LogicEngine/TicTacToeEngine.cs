using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.LogicEngine
{
    /// <summary>
    /// 
    /// </summary>
    public class TicTacToeEngine
    {
        private GameData gameData;
        const string emptyBoard = "         ";
        public TicTacToeEngine()
        {
            gameData = new GameData { Board = emptyBoard.ToCharArray(), CurrentTurn = 0, TurnData = new List<TurnData>() };
        }

        public TicTacToeEngine(GameData gameData)
        {
            this.gameData = gameData;
        }

        public IPlayer XPlayer;

        public IPlayer OPlayer;

        public GameData GetGameData()
        {
            return gameData;
        }

        public void SelectSpace(int space)
        {
            if(space > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(space));
            }
            if(gameData.Board[space] != ' ')
            {
                throw new RuleViolationException("Space is already taken!");
            }
            gameData.TurnData.Add(new TurnData() 
                { Board = gameData.Board, Move = space, Turn = gameData.CurrentTurn });

            char playerChar = gameData.CurrentTurn % 2 == 0 ? 'x' : 'o';

            gameData.Board[space] = playerChar;

            gameData.CurrentTurn++;

            GameStatus gameStatus = GameStatus.InProgress;
            if (gameData.CurrentTurn == 9)
            {
                gameStatus = GameStatus.Tie;
            }

            if(TicTacToeEngine.IsWin(gameData.Board))
            {
                gameStatus = playerChar == 'x'? GameStatus.XWin : GameStatus.oWin;

            }

            if(gameStatus != GameStatus.InProgress)
            {
                if (OPlayer != null) OPlayer.AlertGameOver(gameStatus);
                if (XPlayer != null) XPlayer.AlertGameOver(gameStatus);
            }
            else if (playerChar == 'x')
            {
                if (OPlayer != null) OPlayer.AlertTurn(gameData);
            }
            else
            {
                if (XPlayer != null) XPlayer.AlertTurn(gameData);
            }
        }

        public static bool IsWin(char[] board)
        {
            if(board.Length != 9)
            {
                throw new RuleViolationException("A board must have 9 positions.");
            }

            for(int i = 0; i < 3; i++)
            {
                int h = i * 3;

                // horizontal win
                if (board[h] != ' ' && board[h] == board[h + 1] && board[h] == board[h + 2])
                {
                    return true;
                }

                // vertical win
                if (board[i] != ' ' && board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    return true;
                }
            }

            // diagonal win
            if (board[4] != ' ' && board[0] == board[4] && board[0] == board[8])
            {
                return true;
            }
            if (board[4] != ' ' && board[2] == board[4] && board[2] == board[6])
            {
                return true;
            }
            return false;
        }
    }
}
