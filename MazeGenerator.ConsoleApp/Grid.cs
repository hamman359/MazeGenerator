using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGenerator.ConsoleApp
{
    public class Grid
    {
        public int Columns { get; }
        public int Rows { get; }
        public int Size => Rows * Columns;

        readonly Cell[][] _grid;

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            _grid = new Cell[Rows][];

            PrepareGrid();
            ConfigureCells();
        }

        protected void PrepareGrid()
        {
            for (int row = 0; row < Rows; row++)
            {
                _grid[row] = new Cell[Columns];

                for (int col = 0; col < Columns; col++)
                {
                    _grid[row][col] = new Cell(row, col);
                }
            }
        }

        protected void ConfigureCells()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    var cell = _grid[row][col];

                    SetNorth(cell, row, col);
                    SetSouth(cell, row, col);
                    SetEast(cell, row, col);
                    SetWest(cell, row, col);
                }
            }
        }

        void SetNorth(Cell cell, int row, int col)
        {
            if (row > 0)
            {
                cell.North = _grid[row - 1][col];
            }
            else
            {
                cell.North = null;
            }
        }

        void SetSouth(Cell cell, int row, int col)
        {
            if (row < Rows - 1)
            {
                cell.South = _grid[row + 1][col];
            }
            else
            {
                cell.South = null;
            }
        }

        void SetEast(Cell cell, int row, int col)
        {
            if (col < Columns - 1)
            {
                cell.East = _grid[row][col + 1];
            }
            else
            {
                cell.East = null;
            }
        }

        void SetWest(Cell cell, int row, int col)
        {
            if (col > 0)
            {
                cell.West = _grid[row][col - 1];
            }
            else
            {
                cell.West = null;
            }
        }

        public Cell GetRandomCell()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            var row = random.Next(Rows);
            var col = random.Next(Columns);

            return _grid[row][col];
        }

        public IEnumerable<Cell[]> IterateRows()
        {
            for (int row = 0; row < Rows; row++)
            {
                yield return _grid[row];
            }
        }

        public IEnumerable<Cell> IterateEachCell()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    yield return _grid[row][col];
                }
            }
        }
    }
}
