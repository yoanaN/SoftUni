using System;
using System.Linq;
using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numComands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            while (numComands > 0)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[2] == "going!")
                {
                    if (names.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(input[0]);
                    }
                }
                else if (input[2] == "not")
                {
                    if (names.Contains(input[0]))
                    {
                        names.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                numComands--;
            }
            Console.WriteLine(string.Join("\n", names));

        }
    }
}