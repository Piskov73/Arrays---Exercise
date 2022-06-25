using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] arrayRotation = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int numberRotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberRotation; i++)
            {
                int tempNumber = arrayRotation[0];
                for (int index = 0; index < arrayRotation.Length-1; index++)
                {
                    
                    arrayRotation[index] = arrayRotation[index+1];
                }
                arrayRotation[arrayRotation.Length-1]=tempNumber;
            }

            Console.WriteLine(String.Join(" ",arrayRotation ));
        }
    }
}
