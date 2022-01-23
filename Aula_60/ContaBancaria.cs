using System;
using System.Globalization;

namespace Course
{
    public class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public double Taxa { get; private set; } = 5.0;

        public ContaBancaria()
        {
            Console.Write("Número da conta: ");
            Conta = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            Titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial [s/n]?: ");
            if (Console.ReadLine().ToLower() == "s")
            {
                Deposito();
            }
            else
                Saldo = 0.0;
        }
        public void Deposito()
        {
            Console.Write("\nDigite um valor para depósito: ");
            Saldo += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void Saque()
        {
            Console.Write("\nDigite um valor para saque: ");
            Saldo -= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) + Taxa;
        }

        public override string ToString()
        {
            return $"\nConta {Conta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }

}
