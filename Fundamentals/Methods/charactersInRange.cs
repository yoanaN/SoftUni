using System;

namespace charactersInRange
{
    internal class charactersInRange
    {

        static void print(char start, char end)
        {
            for (int i = start + 1; i < end; ++i)
            {
                char c = (char)i;
                Console.Write($"{c} ");
            }
        }
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if (start > end)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            print(start, end);


        }
    }
}