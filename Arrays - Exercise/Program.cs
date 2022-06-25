using System;
using System.Linq;


namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldsSize = int.Parse(Console.ReadLine());
            int[] indrcsLadyBugd = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int[] ladybugs = new int[fieldsSize];
            for (int i = 0; i < fieldsSize; i++)
            {
                if (indrcsLadyBugd.Contains(i))
                {
                    ladybugs[i] = 1;
                }
            }
            string comands;
            while ((comands = Console.ReadLine()) != "end")
            {
                string[] relocation = comands.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int position = int.Parse(relocation[0]);
                string direction = relocation[1];
                int lengthRelocation = int.Parse(relocation[2]);
                if (position < 0 || position >= fieldsSize)
                {
                    continue;
                }
                if (ladybugs[position] == 0)
                {
                    continue;
                }
                ladybugs[position] = 0;
                if (direction == "right")
                {
                    if (position + lengthRelocation >= fieldsSize)
                    {
                        continue;
                    }
                    else
                    {
                        position += lengthRelocation;
                        if (ladybugs[position] == 0)
                        {
                            ladybugs[position] = 1;
                        }
                        else
                        {
                            for (int i = position + 1; i < fieldsSize; i++)
                            {
                                if (ladybugs[i] == 0)
                                {
                                    ladybugs[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (direction == "left")
                {
                    if (position - lengthRelocation < 0)
                    {
                        continue;
                    }
                    else
                    {
                        position -= lengthRelocation;
                        if (ladybugs[position] == 0)
                        {
                            ladybugs[position] = 1;
                        }
                        else
                        {
                            for (int i = position - 1; i >= 0; i--)
                            {
                                if (ladybugs[i] == 0)
                                {
                                    ladybugs[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }

            }

            Console.WriteLine(String.Join(" ", ladybugs));
        }
    }
}
