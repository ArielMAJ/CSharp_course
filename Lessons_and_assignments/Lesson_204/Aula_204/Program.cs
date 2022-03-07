using System;
using System.Globalization;
using Aula_204.Entities;
using Aula_204.Services;

namespace Aula_204
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hourly = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double daily = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Vehicle vehicle = new Vehicle(model);
            CarRental carRental = new CarRental(start, end, vehicle);
            
            RentalService.ProcessInvoice(carRental, daily, hourly);

        }
    }
}