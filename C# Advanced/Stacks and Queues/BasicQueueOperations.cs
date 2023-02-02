using System;
using System.Linq;
using System.Collections.Generic;

namespace StacQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (var el in inputNums)
            {
                queue.Enqueue(el);
            }
            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
