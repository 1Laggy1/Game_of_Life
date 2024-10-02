namespace GameOfLife.Test
{
    public class Tests
    {
        GridCells gridCells = null!;
        [SetUp]
        public void Setup()
        {
            gridCells = new GridCells();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void InitializeCells_CreatesCorrectArraySize()
        {


            var cells = gridCells.InitializeCells(1, 8, 5);
            Assert.That(cells.Length, Is.EqualTo(8));

            foreach (var row in cells)
            {
                Assert.That(row.Length, Is.EqualTo(5));
            }
        }

        [Test]
        public void InitializeCells_CreatesNonNullCells()
        {
            var cells = gridCells.InitializeCells(1, 8, 5);

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