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
            var cells = gridCells.Cells;
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
            var cells = gridCells.Cells;

            foreach (var row in cells)
            {
                foreach (var cell in row)
                {
                    Assert.That(cell, !Is.EqualTo(null));
                }
            }
        }
        [Test]
        public void CheckNeighbours_Simple()
        {
            GridCells gridCells = new GridCells(1, 8, 5);
            gridCells.Cells[1][1].alive = true;
            gridCells.Cells[2][1].alive = true;
            gridCells.Cells[0][1].alive = true;
            gridCells.Cells[2][2].alive = true;
            gridCells.oldGenerationCells = gridCells.DeepCopy(gridCells.Cells);
            int actual = gridCells.CheckNeighbors(gridCells.Cells, 1, 1);
            Assert.That(actual, Is.EqualTo(3));
        }
        [Test]
        public void CheckNeighbours_CountThroughEdges()
        {
            GridCells gridCells = new GridCells(1, 8, 5);
            gridCells.Cells[1][1].alive = true;
            gridCells.Cells[2][1].alive = true;
            gridCells.Cells[0][1].alive = true;
            gridCells.Cells[3][2].alive = true;
            gridCells.Cells[5][2].alive = true;
            gridCells.Cells[6][2].alive = true;
            gridCells.Cells[7][2].alive = true;
            gridCells.Cells[7][3].alive = true;
            gridCells.oldGenerationCells = gridCells.DeepCopy(gridCells.Cells);
            int actual = gridCells.CheckNeighbors(gridCells.Cells, 0, 1);
            Assert.That(actual, Is.EqualTo(2));
        }
        [Test]
        public void Evolve_Solitude()
        {
            GridCells gridCells = new GridCells(2, 10, 10);
            gridCells.Cells[1][1].alive = true;
            gridCells.Cells[0][0].alive = true;
            gridCells.Evolve();
            Assert.That(gridCells.Cells[1][1].alive, Is.EqualTo(false));
        }
        [Test]
        public void Evolve_Overpopulation()
        {
            GridCells gridCells = new GridCells(2, 10, 10);
            gridCells.Cells[1][1].alive = true;
            gridCells.Cells[0][0].alive = true;
            gridCells.Cells[0][1].alive = true;
            gridCells.Cells[1][2].alive = true;
            gridCells.Cells[2][2].alive = true;
            gridCells.Cells[3][0].alive = true;
            gridCells.Evolve();
            Assert.That(gridCells.Cells[1][1].alive, Is.EqualTo(false));
        }
    }
}