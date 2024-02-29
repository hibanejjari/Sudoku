using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{

    public class Game
    {
        private Grid grid = new Grid();

        public void SetCellValue(int row, int col, int value)
        {
            grid.SetCell(row, col, value);
        }

        public int GetCellValue(int row, int col)
        {
            return grid.GetCell(row, col);
        }
    }
}