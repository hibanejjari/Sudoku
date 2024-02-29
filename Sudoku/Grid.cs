using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Grid
    {
        private Cell[,] cells = new Cell[9, 9];

        public Grid()
        {
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    cells[row, col] = new Cell(0, false);
                }
            }
        }

        public void SetCell(int row, int col, int value)
        {
            if (row >= 0 && row < 9 && col >= 0 && col < 9)
            {
                cells[row, col].Value = value;
            }
        }

        public int GetCell(int row, int col)
        {
            if (row >= 0 && row < 9 && col >= 0 && col < 9)
            {
                return cells[row, col].Value;
            }
            return -1; // Indicate an invalid or out-of-bounds operation
        }
    }


}