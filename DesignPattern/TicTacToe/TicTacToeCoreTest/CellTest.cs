using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeCore.Module;
using System;

namespace TicTacToeCoreTest
{
    [TestClass]
    public class UnitTest1
    {
        Cell cell1 = new Cell();
        [TestMethod]
        public void Test_WhenACellCreatedMarkHasToBeEmpty()
        {
            
            Assert.AreEqual(cell1.GetMark,MarkType.Empty);
        }
        public void Test_IsCellAlreadyMarked()
        {
            Assert.IsTrue(cell1.GetMark == MarkType.Empty, "Cell is not marked");
        }
        [TestMethod]
        public void Test_ShouldBeAbleToMarkCellX()
        {
            cell1.GetMark = MarkType.X;
            Assert.AreEqual<bool>(true, cell1.IsCellMarked());
        }
        [TestMethod]
        public void Test_ShouldThrowExceptionIfCellIsAlreadyMarked()
        {
            try
            {
                cell1.GetMark = MarkType.O;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void Test_CheckIfBoardIsEmpty()
        {
            Board board = new Board();
            Assert.AreEqual<bool>(true, board.CheckIfBoardIsEmpty());
        }
        [TestMethod]
        public void Test_MarkCellAtLocation()
        {
            Board board = new Board();
            board.MarkCell(0, MarkType.X);
            try
            { board.MarkCell(0, MarkType.O); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod] 
        public void Test_CheckIfBoardIsFull()
        {
            Board board = new Board();
            for (int i = 0; i < 9; i++)
            {
                board.MarkCell(i, MarkType.X);
            }
            Assert.AreEqual<bool>(true, board.CheckIfBoardIsFull());
        }
    }
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void Test_CheckRowResult()
        {
            Board BoardWithRowWin = new Board();
            for (int i = 0; i < 9; i++)
            {
                if (i == 0 | i == 1 | i == 2 | i == 4 | i == 8)
                    BoardWithRowWin.MarkCell(i, MarkType.X);
                if (i == 3 | i == 6 | i == 7 | i == 5)
                    BoardWithRowWin.MarkCell(i, MarkType.O);
            }
            ResultAnalyzer result = new ResultAnalyzer(BoardWithRowWin);
            Assert.AreEqual(ResultType.WIN, result.Analyze());
        }
        [TestMethod]
        public void Test_CheckColResult()
        {
            Board BoardWithColWin = new Board();
            for (int i = 0; i < 9; i++)
            {
                if (i == 1 | i == 3 | i == 4 | i == 7 | i == 8)
                    BoardWithColWin.MarkCell(i, MarkType.O);
                if (i == 0 | i == 2 | i == 6 | i == 5)
                    BoardWithColWin.MarkCell(i, MarkType.X);
            }
            ResultAnalyzer result = new ResultAnalyzer(BoardWithColWin);
            Assert.AreEqual(ResultType.WIN, result.Analyze());

        }
        [TestMethod]
        public void Test_CheckCDiagonalResult()
        {
            Board BoardWithDiagonalWin = new Board();
            for (int i = 0; i < 9; i++)
            {
                if (i == 1 | i == 3 | i == 2 | i == 7 | i == 6)
                    BoardWithDiagonalWin.MarkCell(i, MarkType.O);
                if (i == 0 | i == 5 | i == 4 | i == 8)
                    BoardWithDiagonalWin.MarkCell(i, MarkType.X);
            }
            ResultAnalyzer result = new ResultAnalyzer(BoardWithDiagonalWin);
            Assert.AreEqual(ResultType.WIN, result.Analyze());
        }
        [TestMethod]
        public void Test_CheckDrawResult()
        {
            Board BoardWithDraw = new Board();
            for (int i = 0; i < 9; i++)
            {
                if (i == 1 | i == 3 | i == 5 | i == 8 | i == 6)
                    BoardWithDraw.MarkCell(i, MarkType.O);
                if (i == 0 | i == 2 | i == 4 | i == 7)
                    BoardWithDraw.MarkCell(i, MarkType.X);
            }
            ResultAnalyzer result = new ResultAnalyzer(BoardWithDraw);
            Assert.AreEqual(ResultType.DRAW, result.Analyze());
        }
        [TestMethod]
        public void Test_CheckIncompleteBoardResult()
        {
            Board IncompleteBoard = new Board();
            for (int i = 0; i < 9; i++)
            {
                if (i == 1 | i == 3 | i == 5 | i == 8)
                    IncompleteBoard.MarkCell(i, MarkType.O);
                if (i == 0 | i == 2 | i == 4)
                    IncompleteBoard.MarkCell(i, MarkType.X);
            }
            ResultAnalyzer result = new ResultAnalyzer(IncompleteBoard);
            Assert.AreEqual(ResultType.NORESULT, result.Analyze());
        }

    }

}
