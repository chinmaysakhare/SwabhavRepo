using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Module
{
    public class Board
    {
        private Cell[] cells = new Cell[9];
        public Board()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell();
            }
        }

        public bool CheckIfBoardIsFull()
        {
            int temp = 0;
            foreach (var singlecell in cells)
            {
                if (singlecell.GetMark == MarkType.Empty)
                    temp++; 
            }
            if (temp > 0)
                return false;
            else
                return true;
        }
        public bool CheckIfBoardIsEmpty()
        {
            int temp = 0;
            foreach (var singlecell in cells)
            {
                if (singlecell.GetMark == MarkType.Empty)
                    temp++;
            }
            if (temp == 9)
                return true;
            else return false;
        }
        public void MarkCell(int loc, MarkType mt)
        {
            cells[loc].MarkCell(mt);
        }
        public Cell[] MyBoardCells { get { return cells; }  }

    }
}
