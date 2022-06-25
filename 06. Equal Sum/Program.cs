using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArrays = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            
            for (int index = 0; index < inputArrays.Length; index++)
            {
                //left sum = 3, right sum = 3
                int leftSum = 0;

                int rightSum = 0;

                for (int leftIndex = 0; leftIndex < index; leftIndex++)
                {
                    leftSum+=inputArrays[leftIndex];
                }
                for (int rightIndex = index+1; rightIndex < inputArrays.Length; rightIndex++)
                {
                    rightSum+=inputArrays[rightIndex];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);

                    return;
                }
               
            }
            Console.WriteLine("no");
        }
    }
}
