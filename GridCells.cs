namespace GameOfLife
{
    public class GridCells
    {
        public bool[][] Cells = new bool[8][];
        public bool[][] InitializeCells()
        {
            bool[][] cells = new bool[8][];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new bool[5];

                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new bool();
                }
            }

            return cells;
        }
    }
}
