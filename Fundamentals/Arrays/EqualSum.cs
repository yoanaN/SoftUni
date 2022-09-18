using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static int leftSum(int position,int[] arr)
        {
            if (position == 0)
            {
                return 0;
            }
            else
            {
                int leftSum = 0;
                for (int i = position - 1; i >= 0; i--)
                {
                    leftSum += arr[i];
                }
                return leftSum;
            }
        }
        static int rightSum(int position, int[] arr)
        {
            if (position == arr.Length - 1)
            {
                return 0;
            }
            else
            {
                int rightSum = 0;
                for (int i = position + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }
                return rightSum;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                               .Select(int.Parse)
                               .ToArray();
            int[] numbers=new int[arr.Length];
            int idxNumber = 0;
            for(int h=0; h<arr.Length; h++)
            {
                int left= leftSum(h,arr);
                int right= rightSum(h,arr);

                if (left == right)
                {
                    numbers[idxNumber] = h;
                    idxNumber++;
                }
               

            }
            if (idxNumber > 0)
            {
                for(int g=0; g<idxNumber; ++g)
                {
                    Console.Write($"{numbers[g] }");
                }
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
