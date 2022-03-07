using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_133.Entities
{
    internal class ProductManager
    {
        public List<Product> products { get; protected set; } = new List<Product>();

        public ProductManager()
        {
        }
        public void addProducts()
        {
            Console.Write("Enter the number of products: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= amount; i++)
            {
                addProduct(i);
            }

        }

        public void addProduct(int i_th = 1)
        {
            Console.WriteLine($"Product #{i_th} data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            string typeOfProd = Console.ReadLine().ToLower();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (typeOfProd == "c")
            {
                products.Add(new Product(name, price));
            } else if (typeOfProd == "u") { 
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                products.Add(new UsedProduct(name, price, date));
            }
            else if (typeOfProd == "i")
            {
                Console.Write("Custom fees: ");
                double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(name, price, fee));
            }else
            {
                Console.WriteLine("Incorrect type of product selected. Skipping this product...");
            }
        }

        public void PriceTags()
        {
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }


    }
}
