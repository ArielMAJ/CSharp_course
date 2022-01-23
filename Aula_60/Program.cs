using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            Console.WriteLine(conta);
            conta.Deposito();
            Console.WriteLine(conta);
            conta.Saque();
            Console.WriteLine(conta);
        }
    }
}