using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string product = string.Empty;
            List<string> products = new List <string>();
                    
            for (int i = 0; i < number; i++)
            {
                product = Console.ReadLine();
                products.Add(product);

            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
