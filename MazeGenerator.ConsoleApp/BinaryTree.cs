using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGenerator.ConsoleApp
{
    public static class BinaryTree
    {
        public static void Generate(Grid grid)
        {
            foreach (Cell cell in grid.IterateEachCell())
            {
                var neighbors = new List<Cell>();

                if (cell.North != null)
                {
                    neighbors.Add(cell.North);
                }

                if (cell.East != null)
                {
                    neighbors.Add(cell.East);
                }

                if (!neighbors.Any())
                {
                    continue;
                }

                Random random = new Random();

                var index = random.Next(neighbors.Count);

                var selected = neighbors[index];

                cell.Link(selected);
            }
        }
    }
}
