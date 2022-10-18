using System;
using System.Collections.Generic;
using System.Linq;
namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            { 
                string[] commandArr = command.Split();
                string currentCommand = commandArr[0];

                if (currentCommand == "Add")
                {
                    int commandValue = int.Parse(commandArr[1]);
                    Numbers.Add(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "Remove")
                {
                    int commandValue = int.Parse(commandArr[1]);
                    Numbers.Remove(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "RemoveAt")
                {
                    int commandValue = int.Parse((commandArr[1]));
                    Numbers.RemoveAt(commandValue);
                    //Console.WriteLine(string.Join(" ", Numbers));
                }
                else if (currentCommand == "Insert")
                { 
                    int commandNumber  = int.Parse((commandArr[1]));
                    int commandIndex = int.Parse(commandArr[2]);

                    Numbers.Insert(commandIndex, commandNumber);
                }
            }
            Console.WriteLine(string.Join(" ", Numbers));
        }
    }
}
