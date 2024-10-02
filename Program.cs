using GameOfLife;

internal class Program
{
    GridCells gridCells;
    private static void Main(string[] args)
    {
        ReadGrid();
    }
    public static void PrintGrid(GridCells grid)
    {
        Console.WriteLine($"Generation: {grid.generationNow}");
        for (int i = 0; i < grid.Y; i++)
        {
            for (int j = 0; j < grid.X; j++)
            {
                Console.Write(grid.Cells[j][i].alive ? "+" : ".");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static GridCells ReadGrid(string path = "./input.txt")
    {
        string[] lines = File.ReadAllLines(path);
        string[] firstLine = lines[0].Split(' ');
        int generations = int.Parse(firstLine[0]);
        int x = int.Parse(firstLine[1]);
        int y = int.Parse(firstLine[2]);
        GridCells gridCells = new GridCells(generations, x, y);
        for (int i = 1; i <= gridCells.Y; i++)
        {
            string line = lines[i];
            for (int j = 0; j < gridCells.X; j++)
            {
                if (line[j].ToString() == "+")
                {
                    gridCells.Cells[j][i - 1].alive = true;
                }
                
            }
        }
        PrintGrid(gridCells);
        gridCells.CheckNeighbors(gridCells.Cells, 2, 2);
        return gridCells;
    }
}