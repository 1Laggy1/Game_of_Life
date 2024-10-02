namespace GameOfLife
{
    public class GridCells
    {
        public Cell[][] Cells;
        private Cell[][] oldGenerationCells;
        public int generationNow = 1;
        public int generationsMax;
        
        public int X;
        public int Y;
        public GridCells(int generations, int x, int y){

            generationsMax = generations;
            X = x; Y = y;
            InitializeCells();
            
        }

        public Cell[][] InitializeCells()
        {
            
            Cell[][] cells = new Cell[X][];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[Y];

                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new Cell(i,j);
                }
            }
            Cells = cells;
            return cells;
        }
        public int CheckNeighbors(Cell[][] gridCells, int x, int y)
        {
            return gridCells[x][y].CheckNeighbors(this,new System.Numerics.Vector2(x,y));
        }
    }
}
