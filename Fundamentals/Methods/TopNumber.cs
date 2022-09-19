using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (PrintDigitsDivisible(i) && PrintOddDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool PrintDigitsDivisible(int number)
        {
            bool isDivide = false;
            int sumOfTwoParts = 0;
            while (number > 0)
            {
                sumOfTwoParts += number % 10;
                number /= 10;
            }
            if (sumOfTwoParts % 8 == 0)
            {
                isDivide = true;
            }
            return isDivide;
        }
        static bool PrintOddDigits(int number)
        {
            bool isCorrect = false;
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    isCorrect = true;
                }
                number /= 10;
            }
            return isCorrect;
        }

    }
}