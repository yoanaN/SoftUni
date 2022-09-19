using System;

namespace AddAndSubstract
{
    internal class AddAndSubstract
    {
        static int addFnc(int[] arr)
        {
            return arr[0] + arr[1];
        }

        static int substracktFnc(int[] arr)
        {
            return addFnc(arr) - arr[2];
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(substracktFnc(numbers));
        }
    }
}