using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._1_Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombCharacteristics = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int bombNumber = bombCharacteristics[0];
            int power = bombCharacteristics[1];
            while (numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);
                int leftIndex = Math.Max(bombIndex - power, 0);
                int rightIndex = Math.Min(bombIndex + power, numbers.Count - 1);
                int count = 1 + rightIndex - leftIndex;

                numbers.RemoveRange(leftIndex, count);
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                 sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
