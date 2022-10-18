using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacityOnWagon = int.Parse(Console.ReadLine()); 
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(' ');
                string cmdArgs = cmdArg[0];

                if (cmdArgs == "Add")
                {
                    int wagonWithPassengers = int.Parse(cmdArg[1]);
                    listOfWagons.Add(wagonWithPassengers);
                }
                else
                { 
                    int numberOfPassangers = int.Parse(cmdArg[0]);
                    int sumOfPassangersInWagon = 0;
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (numberOfPassangers <= listOfWagons[i] || numberOfPassangers >= listOfWagons[i])
                        { 
                             sumOfPassangersInWagon = numberOfPassangers + listOfWagons[i];
                            if (sumOfPassangersInWagon <= maxCapacityOnWagon)
                            {
                                listOfWagons[i] += numberOfPassangers;
                                break;
                            }
                        } 
                    }
                }
            }
            Console.WriteLine(String.Join(" ", listOfWagons));
        }
    }
}
