using System;
using System.Linq;
namespace ArrRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int rotation=int.Parse(Console.ReadLine());
            

            if (rotation > arr.Length)
            {
                rotation= rotation-arr.Length;
            }
            int[] reversed = new int[arr.Length];
            int index = arr.Length - rotation;

            if (arr.Length == rotation || rotation==0)
            {
               Console.WriteLine(String.Join(" ", arr));
                return;
            }
            else
            {
                int ix1 = rotation + 1;
                int ix2 = 0;
                
               for(int i=0; i<arr.Length; i++)
                {
                    if (i == 0)
                    {
                        reversed[i] = arr[rotation];

                    }else if (ix1<=arr.Length-1)
                    {
                        reversed[i] = arr[ix1];
                        ix1++;
                       
                    }else if (ix1 > arr.Length - 1)
                    {
                        reversed[i]=arr[ix2];
                        ix2++;
                    }
                   

                }  
               
            }
            Console.WriteLine(String.Join(" ",reversed));
        }

        
    }
}
