using System;
using System.Collections.Generic;
using ExercicioPoli.Entities;

namespace ExercicioPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'c')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new Product(name, price));
                }
                else if (ch == 'i')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    System.Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("PRICE TAGS:");
            foreach(Product p in list)
            {
                System.Console.WriteLine(p.PriceTag());
            }
        }
    }
}
