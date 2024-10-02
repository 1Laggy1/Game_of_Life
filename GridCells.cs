namespace GameOfLife
{
    public class GridCells
    {
        public bool[][] Cells;
        private bool[][] NextGenerationCells;
        int generationNow;
        int generationsMax;
        public bool[][] InitializeCells(int generations, int x, int y)
        {
            generationsMax = generations;
            bool[][] cells = new bool[x][];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new bool[y];

                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new bool();
                }
            }
            Cells = cells;
            return cells;
        }
    }
}
