using System;
using System.Linq;


namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVagons = int.Parse(Console.ReadLine());

            int[] train=new int[numberOfVagons];

            for (int vagons = 0; vagons < numberOfVagons; vagons++)
            {
                train[vagons]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(' ',train));

            Console.WriteLine(train.Sum());

        }
    }
}
