using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(' ');
                string choose = cmdArg[0];
                if (choose == "Add")
                {
                    Addition(input, cmdArg);
                }
                    
                else if (choose == "Insert")
                {
                    int number = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);

                    if (index < 0 || index > input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    input.Insert(index, number);
                }
                else if (choose == "Remove")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index < 0 || index > input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    input.RemoveAt(index);
                }
                else if (choose == "Shift")
                {
                    string direction = cmdArg[1];

                    if (direction == "left")
                    {
                        int count = int.Parse(cmdArg[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int currNum;
                            currNum = input[0];
                            input.RemoveAt(0);
                            input.Add(currNum);
                        }
                    }
                    else
                    {
                        int count = int.Parse(cmdArg[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int currNum = input[input.Count - 1];
                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, currNum);
                        }
                    }

                }
            }
            Console.WriteLine(String.Join(" ", input));
        }

        private static void Addition(List<int> input, string[] cmdArg)
        {
            int number = int.Parse(cmdArg[1]);
            input.Add(number);
        }
    }
}
