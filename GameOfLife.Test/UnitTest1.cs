namespace GameOfLife.Test
{
    public class Tests
    {
        GridCells gridCells = null!;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void InitializeCells_CreatesCorrectArraySize()
        {

            GridCells gridCells = new GridCells(1, 8, 5);
            var cells = gridCells.InitializeCells();
            Assert.That(cells.Length, Is.EqualTo(8));

            foreach (var row in cells)
            {
                Assert.That(row.Length, Is.EqualTo(5));
            }
        }

        [Test]
        public void InitializeCells_CreatesNonNullCells()
        {
            GridCells gridCells = new GridCells(1, 8, 5);
            var cells = gridCells.InitializeCells();

            foreach (var row in cells)
            {
                foreach (var cell in row)
                {
                    Assert.That(cell, !Is.EqualTo(null));
                }
            }
        }
    }
}