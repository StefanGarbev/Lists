using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombCharacteristics = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bombNumber = bombCharacteristics[0];
            int bombPower = bombCharacteristics[1];
            ExplosionDetonation(inputNumbers, bombNumber, bombPower);
            
            int sumOfDigits = 0;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                sumOfDigits += inputNumbers[i];
            }

            Console.WriteLine(sumOfDigits);
        }

        private static void ExplosionDetonation(List<int> inputNumbers, int bombNumber, int bombPower)
        {
            

            while (inputNumbers.Contains(bombNumber))
            {
                int bombIndex = inputNumbers.IndexOf(bombNumber);
                int bombRadiusLeft = Math.Max(bombIndex - bombPower,0);
                int bombRadiusRight = Math.Min(bombIndex + bombPower, inputNumbers.Count-1);
                
                int explosionRange = 1+ bombRadiusRight-bombRadiusLeft;
                inputNumbers.RemoveRange(bombRadiusLeft, explosionRange);
            }
            
        }
    }
}
