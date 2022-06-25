
using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            for (int number = 0; number < input.Length; number++)
            {
                bool topInteger = true;
                for (int index = number+1; index < input.Length; index++)
                {
                    if (input[number] <= input[index])
                    {
                        topInteger= false;
                        continue;
                    }
                }
                if (topInteger)
                {
                    Console.Write(input[number]+" ");
                }
            }
           
        }
      
    }
}
