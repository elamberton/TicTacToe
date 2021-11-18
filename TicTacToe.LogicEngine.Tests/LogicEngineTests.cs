using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.LogicEngine;

namespace TicTacToe.LogicEngine.Tests
{
    [TestClass]
    public class LogicEngineTests
    {
        [TestMethod]
        [ExpectedException(typeof(RuleViolationException))]
        public void TestExistingSpaceFilled()
        {
            char[] board0 = "         ".ToCharArray();
            char[] board1 = "x        ".ToCharArray();
            GameData gameData = new GameData { CurrentTurn = 1, Board = board1, TurnData = new System.Collections.Generic.List<TurnData>() };
            gameData.TurnData.Add(new TurnData { Board = board0, Move = 1, Turn = 0 });

            TicTacToeEngine engine = new TicTacToeEngine(gameData);
            engine.SelectSpace(0);
        }
        [TestMethod]
        public void TestFillOEmptySpace()
        {
            char[] board0 = "         ".ToCharArray();
            char[] board1 = "x        ".ToCharArray();
            GameData gameData = new GameData { CurrentTurn = 1, Board = board1, TurnData = new System.Collections.Generic.List<TurnData>() };
            gameData.TurnData.Add(new TurnData { Board = board0, Move = 1, Turn = 0 });

            TicTacToeEngine engine = new TicTacToeEngine(gameData);
            engine.SelectSpace(1);
            GameData resultGameData = engine.GetGameData();
            Assert.AreEqual('o', resultGameData.Board[1]);
        }
        [TestMethod]
        public void TestFillEmptySpaceFirstMove()
        {
            TicTacToeEngine engine = new TicTacToeEngine();
            engine.SelectSpace(0);
            GameData resultGameData = engine.GetGameData();
            Assert.AreEqual('x', resultGameData.Board[0]);
        }
        [TestMethod]
        public void TestIsWinHorizontalEmpty()
        {
            Assert.IsFalse(TicTacToeEngine.IsWin("         ".ToCharArray()));
        }
        [TestMethod]
        public void TestIsWinHorizontal()
        {
            Assert.IsTrue(TicTacToeEngine.IsWin("xxxoo    ".ToCharArray()));
        }
        [TestMethod]
        public void TestIsWinHorizontalMiddle()
        {
            Assert.IsTrue(TicTacToeEngine.IsWin("   xxxoo ".ToCharArray()));
        }
        [TestMethod]
        public void TestIsWinVertical()
        {
            Assert.IsTrue(TicTacToeEngine.IsWin("x  x  x  ".ToCharArray()));
        }
        [TestMethod]
        [ExpectedException(typeof(RuleViolationException))]
        public void TestIsWinInvalidBoard()
        {
            Assert.IsTrue(TicTacToeEngine.IsWin("x  x  ".ToCharArray()));
        }
    }
}
