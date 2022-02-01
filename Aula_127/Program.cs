using System;
using Aula_127.Entities;

namespace Aula_127
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Ruth", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Ringo", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Kei", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ari", 0.0, 0.01);

            // DOWNCASTING - Operação não segura
            // https://www.c-sharpcorner.com/article/polymorphism-up-casting-and-down-casting/

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }



        }
    }
}
