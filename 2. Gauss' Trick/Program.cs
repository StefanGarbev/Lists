using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> resultNumbers = new List<int>();

            for (int i = 0; i < inputNumbers.Count/2; i++)
            { 
                int sum = inputNumbers[i] + inputNumbers[(inputNumbers.Count-1)-i];
                resultNumbers.Add(sum);
            }
            if (inputNumbers.Count % 2 != 0)
            {
                resultNumbers.Add(inputNumbers[inputNumbers.Count/2]);
            }
            
            Console.WriteLine(String.Join(" ", resultNumbers));
        }
    }
}
