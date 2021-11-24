using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Module
{
    public class ResultAnalyzer
    {
        private Board _board;
        public ResultAnalyzer(Board board)
        {
            _board = board;
        }
        public ResultType Analyze()
        {
            if (_board.CheckIfBoardIsFull() == false)
                return ResultType.NORESULT;
            else if (RowCheck() == true | ColCheck() == true | DiagonalCheck() == true)
                return ResultType.WIN;
            else return ResultType.DRAW;
        }
        private bool RowCheck()
        {
            Cell[] row1 = { _board.MyBoardCells[0], _board.MyBoardCells[1], _board.MyBoardCells[2]};
            Cell[] row2 = { _board.MyBoardCells[3], _board.MyBoardCells[4], _board.MyBoardCells[5]};
            Cell[] row3 = { _board.MyBoardCells[6], _board.MyBoardCells[7], _board.MyBoardCells[8]};
            bool r1 = CompareElements(row1), r2 = CompareElements(row2), r3 = CompareElements(row3);
            
            {
                if (r1 == true | r2 == true | r3 == true)
                    return true;
                else return false;
            }
            
        }
        private bool ColCheck()
        {
            Cell[] col1 = { _board.MyBoardCells[0], _board.MyBoardCells[3], _board.MyBoardCells[6] };
            Cell[] col2 = { _board.MyBoardCells[1], _board.MyBoardCells[4], _board.MyBoardCells[7] };
            Cell[] col3 = { _board.MyBoardCells[2], _board.MyBoardCells[5], _board.MyBoardCells[8] };
            bool c1=CompareElements(col1), c2=CompareElements(col2), c3=CompareElements(col3);
            if (_board.CheckIfBoardIsFull())
            {
                if (c1 == true | c2 == true | c3 == true)
                    return true;
                else return false;
            }
            else
                return false;
        }
        private bool DiagonalCheck()
        {
            Cell[] dig1 = { _board.MyBoardCells[0], _board.MyBoardCells[4], _board.MyBoardCells[8] };
            Cell[] dig2 = { _board.MyBoardCells[2], _board.MyBoardCells[4], _board.MyBoardCells[6] };
            bool d1 = CompareElements(dig1), d2 = CompareElements(dig2);
            if (_board.CheckIfBoardIsFull())
            {
                if (d1 == true | d2 == true )
                    return true;
                else return false;
            }
            else
                return false;
        }
        public bool CompareElements(Cell[] array)
        {
            if (array[0].GetMark == array[1].GetMark && array[1].GetMark == array[2].GetMark)
                return true;
            else return false;
        }
    }
}
