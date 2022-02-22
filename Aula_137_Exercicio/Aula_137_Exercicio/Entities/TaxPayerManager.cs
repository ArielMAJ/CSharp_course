using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_137_Exercicio.Entities
{
    internal class TaxPayerManager
    {
        public List<TaxPayer> taxPayers = new List<TaxPayer>();


        public void addTaxPayers()
        {

            Console.Write("Enter the number of tax payers: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i_th = 1; i_th <= amount; i_th++)
            {
                Console.WriteLine($"Tax payer #{i_th} data:");

                Console.Write("Individual or company (i/c): ");
                string individual_or_company = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine().ToLower();
                Console.Write("Anual Income: $");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (individual_or_company == "i")
                {
                    Console.Write("Health expenditures: ");
                    double health_expenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, income, health_expenses));
                }
                else if (individual_or_company == "c")
                {
                    Console.Write("Number of employees: ");
                    int n_employees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Company(name, income, n_employees));
                }
                else
                {
                    Console.WriteLine("Incorrect type of tax payer selected. Skipping this tax payer...");
                }
            }
        }

        public void TotalTaxes()
        {
            double total = 0;
            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(
                    $"Alex: " +
                    $"$ {taxPayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)} "
                );
                total += taxPayer.TaxesPaid();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }


    }

}
