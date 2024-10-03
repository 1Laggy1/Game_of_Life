using System.Numerics;

namespace GameOfLife
{
    public class Cell
    {
        public bool alive = false;
        //public bool counted = false;
        int X, Y;
        Vector2[] neighboursVectors = new Vector2[8]
        {
            new Vector2(1, 0),

            new Vector2(-1, 0),
            new Vector2(0, 1),
            new Vector2(0, -1),
            new Vector2(1, 1),
            new Vector2(-1, -1),
            new Vector2(1, -1),
            new Vector2(-1, 1)
        };
        public Cell(int x, int y) {
            X = x;
            Y = y;
        }
        public int CheckNeighbors(GridCells grid, Vector2 start)
        {
            int neighbours=0;
            if (alive && !(start.X==X && start.Y==Y))
            {
                neighbours++;
                //counted = true;
                return neighbours;
            }
            else if (!(start.X == X && start.Y == Y))
            {
                return neighbours;   
            }
            Vector2 vector2 = new Vector2(X, Y);
            foreach (Vector2 vector in neighboursVectors)
            {
                neighbours += grid.oldGenerationCells[((X+(int)vector.X) + grid.X) % (grid.X)][(Y+(int)vector.Y + grid.Y) % (grid.Y)].CheckNeighbors(grid, start);
            }
            return neighbours;
        }
    }
}
