using System;
using System.Linq;
using System.Collections.Generic;

namespace StacQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityF = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            foreach(var el in orders)
            {
                queue.Enqueue(el);
            }

            Console.WriteLine(queue.Max());
            for(int i = 0; i < orders.Length; i++)
            {
                quantityF -= orders[i];
                if (quantityF>=0)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(' ', queue)}");
                    return;
                }                    
            }
            Console.WriteLine("Orders complete");
        }
    }
}
