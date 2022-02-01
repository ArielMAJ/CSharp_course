using System;
using Aula_126.Entities;

namespace Aula_126
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Meown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

        }
    }
}