using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> numbersList2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();
            MergingLists(numbersList1, numbersList2, resultList);
        }

        private static void MergingLists(List<int> numbersList1, List<int> numbersList2, List<int> resultList)
        {
            if (numbersList1.Count > numbersList2.Count)
            {
                for (int i = 0; i < numbersList2.Count; i++)
                {
                    resultList.Add(numbersList1[i]);
                    resultList.Add(numbersList2[i]);
                }
                for (int i = numbersList2.Count; i < numbersList1.Count; i++)
                {
                    resultList.Add(numbersList1[i]);
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
            else
            {
                for (int i = 0; i < numbersList1.Count; i++)
                {
                    resultList.Add(numbersList1[i]);
                    resultList.Add(numbersList2[i]);
                }
                for (int i = numbersList1.Count; i < numbersList2.Count; i++)
                {
                    resultList.Add(numbersList2[i]);
                }
                Console.WriteLine(string.Join(" ", resultList));
            }
        }
    }
}
