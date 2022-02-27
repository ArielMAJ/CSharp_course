using System;
using System.Globalization;
using Aula_146_Assignment.Entities;
using Aula_146_Assignment.Entities.Exceptions;

namespace Aula_146_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.Write("\nEnter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(withdraw);
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException ex) { Console.WriteLine("Withdraw exception: " + ex); }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}