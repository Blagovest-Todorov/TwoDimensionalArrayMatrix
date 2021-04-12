using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                { 1, 2, 3, 4},
                { 5, 6 , 7, 8}
            };

            Console.WriteLine(matrix.GetLength(0)); // We take the numbs of rows
            Console.WriteLine(matrix.GetLength(1)); // we take the numbs of cols
        }
    }
}
