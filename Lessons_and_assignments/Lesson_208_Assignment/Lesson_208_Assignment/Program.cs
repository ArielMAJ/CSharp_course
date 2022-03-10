using System;
using System.Globalization;
using Lesson_208_Assignment.Entities;
using Lesson_208_Assignment.Services;

namespace Lesson_208_Assignment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int n_installments = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, contractValue);

            ContractService.ProcessContract(contract, new BasicPaymentService(), n_installments);

            Console.WriteLine(contract);
        }
    }
}