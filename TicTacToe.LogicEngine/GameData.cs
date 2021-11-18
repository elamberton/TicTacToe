using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.LogicEngine
{
    public class GameData
    {
        public int CurrentTurn;
        public char[] Board;
        public List<TurnData> TurnData;
    }
}
