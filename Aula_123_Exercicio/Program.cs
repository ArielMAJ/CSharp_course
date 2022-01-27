using System;
using System.Globalization;
using Aula_123_Exercicio.Entities;
using Aula_123_Exercicio.Entities.Enums;

namespace Aula_123_Exercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter client data:\n");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail= Console.ReadLine();
            Console.Write("Birth data (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //Client client = new(clientName, clientEmail, birthDay);
            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new(clientName, clientEmail, birthDay);
            Order order = new(client, status);

            Console.Write("How many items to this order: ");
            int nItems = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            for (int i = 1; i <= nItems; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQtt = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product prod = new(prodName, prodPrice);
                OrderItem oItem = new(prod, prodQtt, prodPrice);
                order.addItem(oItem);
            }

            Console.WriteLine(order);
            
        }
    }
}