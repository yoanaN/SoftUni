using System;
using System.Linq;
using System.Collections.Generic;

namespace StacQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int query = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();
            for (int i = 0; i < query; i++)
            {                
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();               
                
                switch (input[0])
                {                    
                    case 1:
                        {
                            stack.Push(input[1]);
                        }break;
                    case 2:
                        {
                            if (stack.Count() > 0)
                                stack.Pop();
                        }break;
                    case 3:
                        {
                            if (stack.Count() > 0)                            
                                Console.WriteLine(stack.Max());                               
                            
                        }
                            break;
                    case 4:
                        {
                            if (stack.Count() > 0)                            
                                Console.WriteLine(stack.Min());
                            
                        }break;
                    default:
                        break;
                }              
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
