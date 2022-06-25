

using System;
using System.Linq;


namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intigerN=int.Parse(Console.ReadLine());
            int [] firstArrays=new int[intigerN];
            int [] sekcondArrays=new int[intigerN];
            for (int indexArays = 0; indexArays < intigerN; indexArays++)
            {
                int[] inputArrays = Console.ReadLine().
                    Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();
                if (indexArays % 2 == 0)
                {
                    firstArrays[indexArays] = inputArrays[0];
                    sekcondArrays[indexArays]=inputArrays[1];
                }
                else
                {
                    firstArrays[indexArays] = inputArrays[1];
                    sekcondArrays[indexArays] = inputArrays[0];
                }
            }
            Console.WriteLine(String.Join(' ',firstArrays));
            Console.WriteLine(String.Join(' ',sekcondArrays));
        }
    }
}
