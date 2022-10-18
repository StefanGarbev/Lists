using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            inputNumbers.RemoveAll(n => n < 0);

            if (inputNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputNumbers.Reverse();
                Console.WriteLine(String.Join(" ", inputNumbers));
            }

        }
    }
}
