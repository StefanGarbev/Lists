using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._1_Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

             //Console.WriteLine(string.Join(" ", list));
            for (int i = 0; i < list.Count; i++)
            {
                List<string> numbers = list[i]
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

               // Console.WriteLine(string.Join(" ", numbers));
                for (int j = 0; j < numbers.Count; j++)
                {
                    Console.Write($"{numbers[j]} ");   
                }
            }
        }
    }
}
