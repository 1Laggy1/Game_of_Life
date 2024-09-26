using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GridCells
    {
        public Cell[][] Cells = new Cell[8][];
        public Cell[][] InitializeCells()
        {
            Cell[][] cells = new Cell[8][];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[5];

                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new Cell();
                }
            }

            return cells;
        }
    }
}
