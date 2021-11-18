using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.LogicEngine
{
    public enum GameStatus
    {
        Starting,
        InProgress,
        Tie,
        XWin,
        oWin
    }
    public interface IPlayer
    {
        string Handle { get; set; }
        string Team { get; set; }
        void AlertTurn(GameData gameData);
        void AlertGameOver(GameStatus gameStatus);
    }
}
