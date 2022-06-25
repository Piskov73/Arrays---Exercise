



using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArrays = Console.ReadLine().Split(' ');

            string[] secondArrays = Console.ReadLine().Split(' ');

            for (int indexSekondArrays = 0; indexSekondArrays < secondArrays.Length; indexSekondArrays++)
            {
                for (int indexFirstArrays = 0; indexFirstArrays < firstArrays.Length; indexFirstArrays++)
                {
                    if (firstArrays[indexFirstArrays] == secondArrays[indexSekondArrays])
                    {
                        Console.Write(firstArrays[indexFirstArrays]+" ");
                    }
                }
            }

        }
    }
}
