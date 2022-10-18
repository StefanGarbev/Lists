using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputInfo = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            { 
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commande = cmdArg[0];

                if (commande == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    IndexCheck(inputInfo, ref startIndex, ref endIndex);
                    TextMerging(inputInfo, startIndex, endIndex);
                    Console.WriteLine(string.Join(" ", inputInfo));
                }
            }
        }

        private static void TextMerging(List<string> inputInfo, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                string currentWord = inputInfo[startIndex];
                mergedText += currentWord;
                inputInfo.RemoveAt(startIndex);
            }
            inputInfo.Insert(startIndex, mergedText);
        }

        private static void IndexCheck(List<string> inputInfo, ref int startIndex, ref int endIndex)
        {
            if (0 > startIndex)
            {
                startIndex = 0;

            }
            if (startIndex >= inputInfo.Count)
            {
                startIndex = inputInfo.Count - 1;
            }
            if (endIndex <= 0)
            {
                endIndex = 0;
            }
            if (endIndex > inputInfo.Count)
            {
                endIndex = inputInfo.Count - 1;
            }
        }
    }
}
