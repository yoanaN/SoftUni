using System;
using System.Linq;
namespace TopInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                               .Select(int.Parse)
                               .ToArray();

            //worst case
            int[] topInteger=new int[arr.Length];
            int topIntegerIndex=0;

            for(int i = 0; i < arr.Length; ++i)
            {
                int currentNum=arr[i];
                bool isTopInteger = true;

                for(int j = i+1;j < arr.Length; ++j)
                {
                    int nextNum=arr[j];
                    if (currentNum <= nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topInteger[topIntegerIndex] = currentNum;
                    topIntegerIndex++;  
                }
            }
            for(int k=0; k <= topIntegerIndex; ++k)
            {
                Console.Write($"{topInteger[k]} ");
            }
        }
    }
}
