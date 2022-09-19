using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void matrix(int n)
        {

            for (int i = 1; i <= n; ++i)
            {

                for (int j = 1; j < n; ++j)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine($"{n} ");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            matrix(num);


        }
    }
}