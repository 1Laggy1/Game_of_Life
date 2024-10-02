namespace GameOfLife
{
    public class GridCells
    {
        public bool[][] Cells;
        private bool[][] oldGenerationCells;
        public int generationNow = 1;
        public int generationsMax;
        
        public int Rows;
        public int Columns;

        public bool[][] InitializeCells(int generations, int x, int y)
        {
            generationsMax = generations;
            Rows = x; Columns = y;
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
            Program.PrintGrid(this);
            return cells;
        }
    }
}
