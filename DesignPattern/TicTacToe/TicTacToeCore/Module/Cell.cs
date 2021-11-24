using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Module
{
    public class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.Empty;
        }
        public MarkType GetMark { get { return _mark; } set { _mark = MarkType.X; } }
        public bool IsCellMarked()
        {
            if (_mark != MarkType.Empty)
            {
                return true;
            }
            else
                return false;
        }
        public void MarkCell(MarkType mark)
        {
            if (_mark == MarkType.Empty)
            {
                _mark = mark;
            }
            else
                throw new Exception("Cell is already Assigned");
        }
        
    }
}
