using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passengers=new int[n];
            int sum = 0;
            for(int i = 0; i <passengers.Length; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }

            for(int j = 0; j <passengers.Length; j++)
            {
                Console.Write($"{passengers[j]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
