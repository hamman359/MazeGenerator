using System;
using System.Collections.Generic;

namespace MazeGenerator.ConsoleApp
{
    public static class Sidewinder
    {
        public static void Generate(Grid grid)
        {
            foreach (Cell[] cells in grid.IterateRows())
            {
                var run = new List<Cell>();
                var random = new Random();

                foreach (var cell in cells)
                {
                    run.Add(cell);

                    var atEastBoundary = cell.East == null;
                    var atNorthBoundary = cell.North == null;

                    var shouldCloseOut = atEastBoundary
                        || (!atNorthBoundary && random.Next(2) == 0);

                    if (shouldCloseOut)
                    {
                        int index = random.Next(run.Count);
                        var member = run[index];

                        if (member.North != null)
                        {
                            member.Link(member.North);
                        }

                        run.Clear();
                    }
                    else
                    {
                        cell.Link(cell.East);
                    }
                }
            }
        }
    }
}
