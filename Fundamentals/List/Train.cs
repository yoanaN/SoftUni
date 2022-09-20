using System;
using System.Linq;
using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                if (input.Length == 2)
                {
                    wagon.Add(int.Parse(input[1]));
                }
                else if (input.Length == 1)
                {
                    int addNum = int.Parse(input[0]);
                    for (int i = 0; i < wagon.Count; ++i)
                    {
                        if (wagon[i] + addNum <= maxCapacity)
                        {
                            wagon[i] += addNum;
                            break;
                        }
                    }
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(' ', wagon));
        }
    }
}
