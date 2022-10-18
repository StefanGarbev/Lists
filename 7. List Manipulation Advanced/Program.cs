using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            bool isChange = false;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command.Split();
                string currentCommand = commandArr[0];
                

                if (currentCommand == "Add")
                {
                    isChange = true;
                    int commandValue = int.Parse(commandArr[1]);
                    Numbers.Add(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "Remove")
                {
                    isChange = true;
                    int commandValue = int.Parse(commandArr[1]);
                    Numbers.Remove(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "RemoveAt")
                {
                    isChange = true;
                    int commandValue = int.Parse((commandArr[1]));
                    Numbers.RemoveAt(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "Insert")
                {
                    isChange = true;
                    int commandNumber = int.Parse((commandArr[1]));
                    int commandIndex = int.Parse(commandArr[2]);

                    Numbers.Insert(commandIndex, commandNumber);
                }
                else if (currentCommand == "Contains")
                {
                    int commandNumber = int.Parse(commandArr[1]);
                    if (Numbers.Contains(commandNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentCommand == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        if (Numbers[i] % 2 == 0)
                        {
                            evenNumbers.Add(Numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", evenNumbers));
                }
                else if (currentCommand == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        if (Numbers[i] % 2 != 0)
                        {
                            oddNumbers.Add(Numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", oddNumbers));
                }
                else if (currentCommand == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < Numbers.Count; i++)
                    {
                        sum += Numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (currentCommand == "Filter")
                {
                    string condition = commandArr[1];
                    int number = int.Parse(commandArr[2]);
                    int listNumer = 0;

                    if (condition == "<")
                    {
                        for (int i = 0; i < Numbers.Count; i++)
                        {
                            listNumer = Numbers[i];
                            if (listNumer < number)
                            {
                                Console.Write(listNumer + " ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        for (int i = 0; i < Numbers.Count; i++)
                        {
                            listNumer = Numbers[i];
                            if (listNumer > number)
                            {
                                Console.Write(listNumer + " ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < Numbers.Count; i++)
                        {
                            listNumer = Numbers[i];
                            if (listNumer >= number)
                            {
                                Console.Write(listNumer + " ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < Numbers.Count; i++)
                        {
                            listNumer = Numbers[i];
                            if (listNumer <= number)
                            {
                                Console.Write(listNumer + " ");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine();
                    }
                }  
            }
            if (isChange == true)
            {
                Console.WriteLine(string.Join(" ", Numbers));
            }
        }
    }
}
