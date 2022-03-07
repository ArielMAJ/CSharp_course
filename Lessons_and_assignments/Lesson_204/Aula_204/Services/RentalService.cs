using System;
using Aula_204.Entities;
namespace Aula_204.Services
{
    internal static class RentalService
    {
        public static void ProcessInvoice(CarRental carRental, double pricePerDay, double pricePerHour)
        {
            TimeSpan duration = carRental.End - carRental.Start;
            double basicPayment;

            if (duration.TotalHours > 12)
                basicPayment = Math.Ceiling(duration.TotalDays) * pricePerDay;
            else
                basicPayment = Math.Ceiling(duration.TotalHours) * pricePerHour;

            carRental.Invoice = new Invoice(basicPayment, BrazilTaxService.Tax(basicPayment));
            Console.WriteLine(carRental.Invoice);
        }
    }
}
