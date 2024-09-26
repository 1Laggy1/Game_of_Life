using GameOfLife;

internal class Program
{
    public Cell[][] Сells = new Cell[8][];
    private void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Сells = InitializeCells();
    }
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