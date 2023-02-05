using System;
using System.Linq;
using System.Collections.Generic;

namespace StacQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCap = int.Parse(Console.ReadLine());
            int rackCnt = 1;
            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= rackCap)
                {
                    stack.Pop();
                }
                else
                {
                    rackCnt++;
                    sum = 0;
                }
            }

            Console.WriteLine(rackCnt);
        }
    }
}
