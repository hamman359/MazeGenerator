using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGenerator.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(10,10);

            BinaryTree.Generate(grid);

            Console.WriteLine("Binary Tree");
            Console.WriteLine(grid.ToString());

            var grid2 = new Grid(10, 10);

            Sidewinder.Generate(grid2);
            Console.WriteLine("Sidewinder");
            Console.WriteLine(grid2.ToString());

        }
    }
}
