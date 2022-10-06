using System;
using System.Collections.Generic;
using System.Linq;


namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,] matrix = new string[sizeM[0], sizeM[1]];           

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); ++row)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); ++col)
                {
                    matrix[row, col] = line[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                  
                    if (matrix[i,j] == matrix[i, j+1]&& matrix[i,j]==matrix[i+1,j+1] &&matrix[i + 1, j] == matrix[i + 1, j + 1])
                    {
                            count++;                            
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
