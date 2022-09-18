using System;
using System.Linq;
using System.Collections.Generic;
namespace ZigZag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] top=new int[rows];
            int[] bottom=new int[rows];
            int index1 = 0;
            for (int i = 1; i <= rows; i++)
            {
                
                int[] vs = Console.ReadLine().Split(' ')
                                  .Select(int.Parse)
                                  .ToArray();
                int first = vs[0];
                int second = vs[1];

                    if (i % 2 != 0)
                    {
                        top[index1] = first;
                        bottom[index1] = second;
                    index1++;
                        continue;

                    }
                    else
                    {
                        bottom[index1] = first;
                        
                        top[index1]=second;
                    index1++;

                        continue;
                    }

              
            }
            Console.WriteLine(String.Join(" ", top));
            Console.WriteLine(String.Join(" ", bottom));
        }
    }
}
