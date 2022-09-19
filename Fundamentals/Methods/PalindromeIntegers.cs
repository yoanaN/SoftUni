using System;
using System.Linq;
using System.Collections.Generic;

namespace MiddleElement
{
    internal class Program
    {
        static void isPalindrom(int num)
        {
            int countNumbers = countNumber(num);
            int[] numbers = new int[countNumbers];

            bool isPal = true;

            int count = 0;
            int n = num;

            while (n != 0)
            {
                numbers[count] = n % 10;
                n /= 10;
                count++;
            }

            for (int j = 0; j < countNumbers; ++j)
            {
                if (numbers[j] != numbers[count - 1])
                {
                    isPal = false;
                }
                count--;
                if (j == count)
                {
                    break;
                }
            }
            Console.WriteLine(isPal);
        }
        static int countNumber(int n)
        {
            int counter = 0;
            for (int i = n; i > 0; i /= 10)
            {
                counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                int num = int.Parse(command);
                isPalindrom(num);
                command = Console.ReadLine();
            }



        }
    }
}
