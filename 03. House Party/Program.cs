using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> NamesInList = new List<string>(); 
            int numberofCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofCommand; i++)
            {
                string allCommand = Console.ReadLine();
                string[] command = allCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                if (command.Length == 3)
                {
                 
                    if (NamesInList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        continue;
                    }

                    NamesInList.Add(command[0]);
                }
                
                if (command.Length == 4)
                {
                    if (!NamesInList.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                        continue;
                    }

                    NamesInList.Remove(command[0]);

                }
            }
            foreach (string name in NamesInList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
