using System.Numerics;
namespace GameOfLife
{
    public class GridCells
    {
        public Cell[][] Cells;
        public Cell[][] oldGenerationCells;
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
            return gridCells[x][y].CheckNeighbors(this,new Vector2(x,y));
        }
        public void Evolve()
        {
            oldGenerationCells = DeepCopy(Cells);
            generationNow++;
            for (int i = 0; i < Cells.Length; i++)
            {
                for (int j = 0; j < Cells[i].Length; j++)
                {
                    int neighbours = oldGenerationCells[i][j].CheckNeighbors(this, new Vector2(i, j));
                    if (neighbours == 3)
                    {
                        Cells[i][j].alive = true;
                    }
                    else if (neighbours < 2 || neighbours > 3)
                    {
                        Cells[i][j].alive = false;
                    }
                }
            }
        }
        public Cell[][] DeepCopy(Cell[][] original)
        {
            int rows = original.Length;
            int cols = original[0].Length;

            Cell[][] copy = new Cell[rows][];

            for (int i = 0; i < rows; i++)
            {
                copy[i] = new Cell[cols];
                for (int j = 0; j < cols; j++)
                {
                    copy[i][j] = new Cell(i,j)
                    {
                        alive = original[i][j].alive
                    };
                }
            }

            return copy;
        }

    }
}
