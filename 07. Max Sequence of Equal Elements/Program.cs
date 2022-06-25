using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int maxNumb =0;
            int tempCounter = 1;
            int counterMax = 0;
            for (int index = 0; index < inputArray.Length-1; index++)
            {
                if (inputArray[index] == inputArray[index+1])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;

                }
                if (tempCounter > counterMax)
                {
                    counterMax = tempCounter;
                    maxNumb = inputArray[index];
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(maxNumb + " ");
            }
        }
    }
}
