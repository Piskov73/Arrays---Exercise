
using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DNA lengthсхш
            int lengthDNA=int.Parse(Console.ReadLine());

            string input=Console.ReadLine();
            int[] bestDNA = new int[lengthDNA];
            int bestLength = 0;
            int bestStartIndex = 100;
            int bestSum=0;
            int bestCourentIndex = 0;
            int courentIndex = 0;


            while (input!= "Clone them!")
            {
                courentIndex++;

                int lenghtDna = 1;

                int startIndex = -1;

                int sum = 0;


                int[] inpudDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < inpudDNA.Length-1; i++)
                {
                    if( inpudDNA[i] == 1 && inpudDNA[i] == inpudDNA[(i + 1)])
                    {
                        lenghtDna++;
                        startIndex = i + 2 - lenghtDna;

                    }
                }
                sum = inpudDNA.Sum();
                if (lenghtDna > bestLength)
                {
                    bestDNA = inpudDNA;
                    bestLength=lenghtDna;
                    bestStartIndex=startIndex;
                    bestSum = sum;
                    bestCourentIndex = courentIndex;
                }
                else if (lenghtDna == bestLength)
                {
                    if (bestStartIndex > startIndex)
                    {
                        bestDNA = inpudDNA;
                        bestLength = lenghtDna;
                        bestStartIndex = startIndex;
                        bestSum = sum;
                        bestCourentIndex = courentIndex;
                    }
                    else if (bestStartIndex == startIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestDNA = inpudDNA;
                            bestLength = lenghtDna;
                            bestStartIndex = startIndex;
                            bestSum = sum;
                            bestCourentIndex = courentIndex;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            //Best DNA sample 2 with sum: 2.
            Console.WriteLine($"Best DNA sample {bestCourentIndex} with sum: {bestSum}.");
            Console.WriteLine(String.Join(' ',bestDNA));
            
        }
    }
}
