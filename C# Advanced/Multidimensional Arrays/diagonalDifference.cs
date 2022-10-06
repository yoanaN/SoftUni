using System;
using System.Collections.Generic;
using System.Linq;


namespace MultidimentionalsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());           
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

          
           for(int row = 0; row < matrix.GetLength(0); ++row)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); ++col)
                {
                    matrix[row, col] = line[col];
                }
            }
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int difference=0;

            for(int r = 0; r < matrix.GetLength(0); ++r)
            {
                primaryDiagonalSum += matrix[r, r];
                secondaryDiagonalSum += matrix[r, matrix.GetLength(0) - 1 - r];
                difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            }
           

            Console.WriteLine(difference);
           
        }
    }
 
}
