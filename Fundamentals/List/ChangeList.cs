using System;
using System.Linq;
using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                                               .Split(' ')
                                               .Select(int.Parse)
                                               .ToList();
            string[] comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (comands[0] != "end")
            {
                switch (comands[0])
                {
                    case "Delete":
                        {
                            while (list.Contains(int.Parse(comands[1])))
                            {
                                list.Remove(int.Parse(comands[1]));
                            }
                        }
                        break;
                    case "Insert":
                        {
                            list.Insert(int.Parse(comands[2]), int.Parse(comands[1]));
                        }
                        break;
                }
                comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            }
            Console.WriteLine(String.Join(' ', list));
        }
    }
}