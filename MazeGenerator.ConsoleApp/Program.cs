using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGenerator.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == null)
            {
                Console.WriteLine($"You must provide at least an algorithm name");
                return;
            }

            string algorithm = args[0];
            int rows = args.Length >= 2 ? Convert.ToInt32(args[1]) : 10;
            int cols = args.Length >= 3 ? Convert.ToInt32(args[2]) : 10;

            var grid = new Grid(rows,cols);

            switch (algorithm)
            {
                case "BinaryTree":
                    BinaryTree.Generate(grid);
                    break;
                case "Sidewinder":
                    Sidewinder.Generate(grid);
                    break;
                default:
                    Console.WriteLine($"'{algorithm}' not implemented");
                    return;
            }

            Console.WriteLine(algorithm);
            Console.WriteLine(grid.ToString());

        }
    }
}
