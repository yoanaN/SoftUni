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

            Stack<int> stack = new Stack<int>();
            foreach(var el in inputNums)
            {
                stack.Push(el);
            }
            for(int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine(0);
            }else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
