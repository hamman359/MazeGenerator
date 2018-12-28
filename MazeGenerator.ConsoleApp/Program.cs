using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGenerator.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(20,20);

            //while (cell.Column != 4)
            //{

            //    cell = grid.GetRandomCell();
            //}
            //for (int i = 0; i < 200; i++)
            //{

            //    Cell cell = grid.GetRandomCell();
            //    Console.WriteLine($"Row: {cell.Row}, Column: {cell.Column}");
            //}

            //var rows = grid.IterateRows();

            //foreach (var row in rows)
            //{
            //    Console.WriteLine($"Row: {row.Length}");
            //}
                       
            //var cells = grid.IterateEachCell();

            //foreach (var cell in cells)
            //{
            //    Console.WriteLine($"Row: {cell.Row}, Col: {cell.Column}, Links: {cell.Links.Count}");
            //}

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.On(grid);

            //cells = grid.IterateEachCell();

            //foreach (var cell in cells)
            //{
            //    Console.WriteLine($"Row: {cell.Row}, Col: {cell.Column}, Links: {cell.Links.Count}");
            //}

            Console.WriteLine(grid.ToString());

            var grid2 = new Grid(20, 20);
            
            binaryTree.On(grid2);

            Console.WriteLine(grid2.ToString());

        }
    }
}
