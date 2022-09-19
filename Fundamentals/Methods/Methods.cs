using System;

namespace Methods
{
    internal class Methods
    {
        static int smallestNumber(int[] number)
        {
            int temp = number[0];
            for (int i = 1; i < number.Length; ++i)
            {
                if (temp > number[i])
                {
                    temp = number[i];
                }
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(smallestNumber(arr));
        }
    }
}