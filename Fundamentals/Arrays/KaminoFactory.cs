using System;
using System.Linq;
using System.Collections.Generic;
namespace KaminoFactory
{
    internal class Program
    {
        static int countArr1(int[] arr)
        {
            int count = 0;
            if (arr[arr.Length - 1] == 1) count++;
            for (int i = 0; i < arr.Length - 1; ++i)
            {

                if (arr[i] == arr[i + 1])
                {
                    count++;

                }
            }

            return count;
        }
        static int index1(int[] arr)
        {
            int idx = 0;
            for (int j = 0; j < arr.Length; ++j)
            {
                if (arr[j] == 1)
                {
                    idx = j;
                    break;
                }
            }
            return idx;
        }

        static void print(int[] arr)
        {
            for (int i = 0;i < arr.Length; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void changeArr(int[] arr1,int[] arr2)
        {
            for (int h = 0; h < arr1.Length; ++h)
            {
                arr2[h] = arr1[h];
            }
            
        }
        
        static void Main(string[] args)
        {
            int sequenceLength=int.Parse(Console.ReadLine());
            string command=Console.ReadLine();
            string st = command;
            int[] numbers = command
                            .Split('!', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int startingIdx=index1(numbers);

            int[] sequence=new int[sequenceLength];//the final arr
            int curentIdx = 0;
            int count = 0;//the count of 1's 
            int maxCount = 0;//the max count from all arr
            int insertedArr = 0;

            while(command!="Clone them!")
            {
                numbers = command
                       .Split('!', StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();

                //fund the count of 1's
                count = countArr1(numbers);


                //the index of first appereance of 1
                curentIdx=index1(numbers);
               

                //change arr
                if (count > maxCount)
                {
                   changeArr(numbers,sequence);
                   maxCount = count;
                   insertedArr++;

                }else if (count == maxCount)
                {
                    if (startingIdx > curentIdx)
                    {
                        changeArr(numbers, sequence);
                        insertedArr++;
                    }
                }

                command = Console.ReadLine();
               
            }
            
            int finalCount=countArr1(sequence);
            if(sequence[sequence.Length-1] == 1)
            {
                finalCount++;
            }
            Console.WriteLine($"Best DNA sample {insertedArr} with sum: {finalCount}.");
            print(sequence);

        }
    }
}
