using GameOfLife;

internal class Program
{
    string path = "./input.txt";
    private static void Main(string[] args)
    {
        
    }
    public static void PrintGrid(GridCells grid)
    {
        Console.WriteLine($"Generation: {grid.generationNow}");
        for (int i = 0; i < grid.Rows; i++)
        {
            for(int j = 0; j < grid.Columns; j++)
            {
                Console.Write(grid.Cells[i][j] ? "+" : ".");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}