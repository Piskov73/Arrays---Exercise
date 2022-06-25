using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray= Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int index = 0; index < inputArray.Length-1; index++)
            {
                for (int i = index+1; i < inputArray.Length; i++)
                {
                    if ((inputArray[index] + inputArray[i]) == magicSum)
                    {
                        Console.WriteLine($"{inputArray[index]} { inputArray[i]}");
                    }
                }
                
            }
        }
    }
}
