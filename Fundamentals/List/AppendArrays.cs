using System;
using System.Linq;
using System.Collections.Generic;
namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().
                Split('|', StringSplitOptions.RemoveEmptyEntries).
                ToList();
            List<int> output = new List<int>();

            int countSecuences = input.Count;
            for (int i = countSecuences - 1; i >= 0; --i)
            {
                List<int> numInput = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < numInput.Count; ++j)
                {
                    output.Add(numInput[j]);
                }
            }

            Console.WriteLine(string.Join(' ', output));
        }
    }
}