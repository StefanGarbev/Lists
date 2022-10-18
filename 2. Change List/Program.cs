using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> InputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            command = DeleteOrInsert(InputNumbers);
            Console.WriteLine(string.Join(" ", InputNumbers));
        }

        private static string DeleteOrInsert(List<int> InputNumbers)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commande = cmdArg[0];

                if (commande == "Delete")
                {
                    int elements = int.Parse(cmdArg[1]);
                    InputNumbers.RemoveAll(x => x == elements);
                }
                else if (commande == "Insert")
                {
                    int elements = int.Parse(cmdArg[1]);
                    int position = int.Parse(cmdArg[2]);
                    InputNumbers.Insert(position, elements);
                }

            }

            return command;
        }
    }
}
