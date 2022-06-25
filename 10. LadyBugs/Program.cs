using System;
using System.Linq;


namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexLadyBugs = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            int[] fieldLeydyBugs = new int[fieldSize];

            for (int indexFiled = 0; indexFiled < indexLadyBugs.Length; indexFiled++)
            {
                int index = indexLadyBugs[indexFiled];
                if (index < 0 || index >=fieldSize)
                {
                    continue;
                }

                fieldLeydyBugs[index] = 1;
            }

            string[] comand = Console.ReadLine().Split();

            while (comand[0] != "end")
            {
                int positionLedyBugs = int.Parse(comand[0]);

                string direction = comand[1];

                int jump = int.Parse(comand[2]);

                if (positionLedyBugs >= 0 && positionLedyBugs < fieldSize && fieldLeydyBugs[positionLedyBugs] == 1)
                {
                    bool firsPosition = true;
                    while (true)
                    {
                        if (firsPosition)
                        {
                            fieldLeydyBugs[positionLedyBugs] = 0;
                            firsPosition = false;
                        }
                        if (direction == "right")
                        {
                            positionLedyBugs += jump;
                            if (positionLedyBugs < 0 || positionLedyBugs >= fieldSize)
                            {
                                break;
                            }
                            else
                            {
                                if (fieldLeydyBugs[positionLedyBugs] == 0)
                                {
                                    fieldLeydyBugs[positionLedyBugs] = 1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                        }
                        else if (direction == "left")
                        {
                            positionLedyBugs -= jump;
                            if (positionLedyBugs < 0 || positionLedyBugs >= fieldSize)
                            {
                                break;
                            }
                            else
                            {
                                if (fieldLeydyBugs[positionLedyBugs] == 0)
                                {
                                    fieldLeydyBugs[positionLedyBugs] = 1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }


                comand = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", fieldLeydyBugs));

        }
    }
}
