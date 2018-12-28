using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGenerator.ConsoleApp
{
    public class Cell
    {
        readonly List<Cell> _links;
        public List<Cell> Links => _links;

        public List<Cell> Neighbors
        {
            get
            {
                var neighbors = new List<Cell>();

                if (North != null) neighbors.Add(North);

                if (East != null) neighbors.Add(East);

                if (South != null) neighbors.Add(South);

                if (West != null) neighbors.Add(West);

                return neighbors;
            }
        }

        public Cell North { get; set; }
        public Cell East { get; set; }
        public Cell South { get; set; }
        public Cell West { get; set; }

        public int Row { get; }
        public int Column { get; }

        public Cell(int row, int column)
        {
            this.Row = row;
            this.Column = column;

            _links = new List<Cell>();
        }

        public void Link(Cell cell, bool bidirectional = true)
        {
            _links.Add(cell);

            if (bidirectional)
            {
                cell.Link(this, bidirectional: false);
            }
        }

        public void Unlink(Cell cell, bool bidirectional = true)
        {
            _links.Remove(cell);

            if (bidirectional)
            {
                cell.Unlink(this, bidirectional: false);
            }
        }

        public bool IsLinked(Cell cell)
        {
            return _links.Any(x => x == cell);
        }
    }
}
