using System;

namespace MiddleElement
{
    internal class Program
    {
        static void output(string word)
        {
            int lenght = word.Length;

            if (lenght % 2 == 0)
            {
                double first = Math.Floor((double)lenght / 2 - 1);
                double second = Math.Floor((double)lenght / 2);
                Console.WriteLine($"{word[(int)first]}{word[(int)second]}");
            }
            else
            {
                Console.WriteLine(word[lenght / 2]);
            }
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            output(word);



        }
    }
}