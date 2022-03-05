using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            questao01();
            questao02();
        }

        static void questao01()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (pessoa1.Idade>pessoa2.Idade)
                Console.WriteLine($"\nPessoa mais velha: {pessoa1.Nome}");
            else
                Console.WriteLine($"\nPessoa mais velha: {pessoa2.Nome}");
        }
        static void questao02()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados da segunda pessoa: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nSalário médio = {((funcionario1.Salario + funcionario2.Salario)/2).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

    class Pessoa
    {
        public string Nome;
        public int Idade;
    }

    class Funcionario
    {
        public string Nome;
        public double Salario;
    }
}