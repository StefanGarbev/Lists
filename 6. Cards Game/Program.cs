using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            int sumFirstPlayer = 0;
            int sumSecondPlayer = 0;
            
            for (int i = 0; i < firstPlayerDeck.Count; i++)
            {
                if (firstPlayerDeck[i] > secondPlayerDeck[i])
                {
                    firstPlayerDeck.Add(firstPlayerDeck[i]);
                    firstPlayerDeck.Add(secondPlayerDeck[i]);
                    firstPlayerDeck.RemoveAt(i);
                    secondPlayerDeck.RemoveAt(i);
                    i = -1;
                }
                else if (firstPlayerDeck[i] < secondPlayerDeck[i])
                {
                    secondPlayerDeck.Add(secondPlayerDeck[i]);
                    secondPlayerDeck.Add(firstPlayerDeck[i]);
                    secondPlayerDeck.RemoveAt(i);
                    firstPlayerDeck.RemoveAt(i);
                    i = -1;
                }
                else if (firstPlayerDeck[i] == secondPlayerDeck[i])
                {
                    firstPlayerDeck.RemoveAt(i);
                    secondPlayerDeck.RemoveAt(i);
                    i = -1;
                }

                if (firstPlayerDeck.Count == 0)
                {
                    break;
                }
                else if (secondPlayerDeck.Count == 0)
                {
                    break;
                }
            }
            
            if (firstPlayerDeck.Count > 0)
            {
                for (int i = 0; i < firstPlayerDeck.Count; i++)
                { 
                    sumFirstPlayer+=firstPlayerDeck[i];
                }
            }
            else if (secondPlayerDeck.Count > 0)
            {
                for (int i = 0; i < secondPlayerDeck.Count; i++)
                { 
                    sumSecondPlayer+=secondPlayerDeck[i];
                }
            }

            if (sumFirstPlayer > sumSecondPlayer)
            {
                Console.WriteLine($"First player wins! Sum: {sumFirstPlayer}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {sumSecondPlayer}");
            }

        }
    }
}
