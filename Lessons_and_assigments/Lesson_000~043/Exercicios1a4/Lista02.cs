using System;
using System.Globalization;

namespace Course
{
    public class Lista02

    {
        public static void questao01()
        {
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine()); // 0
            if (x < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
        public static void questao02()
        {
            Console.Write("\nDigite um número inteiro: ");
            int x = int.Parse(Console.ReadLine()); // 0
            if (x % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
        public static void questao03()
        {
            Console.Write("\nA: ");
            int a = int.Parse(Console.ReadLine()); //18
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine()); //6

            if (a > b && a % b == 0 || a < b && b % a == 0)
                Console.WriteLine("Múltiplos");
            else
                Console.WriteLine("Não são múltiplos.");

        }
        public static void questao04()
        {
            Console.Write("\nHora inicial: ");
            int hInicio = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            int hFim = int.Parse(Console.ReadLine());

            int total = hFim - hInicio;

            if (hInicio >= hFim)
                total += 24;

            Console.WriteLine($"O jogo durou {total} hora(s).");
        }
        public static void questao05()
        {
            double[] prices = new double[] { 4, 4.5, 5, 2, 1.5 };
            Console.Write("\nCódigo e quantidade (ex.: \"3 2\"): ");
            string[] vect = Console.ReadLine().Split(' ');

            double valorTotal = prices[int.Parse(vect[0]) - 1] * double.Parse(vect[1]);

            Console.WriteLine($"Total: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void questao06()
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x < 0 || x > 100)
                Console.WriteLine("Fora do intervalo");
            else if (x <= 25)
                Console.WriteLine("Intervalo [0,25]");
            else if (x <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (x <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else
                Console.WriteLine("Intervalo (75,100]");
        }
        public static void questao07()
        {
            Console.Write("Digite as coordenadas \"X,Y\": ");
            string[] v = Console.ReadLine().Split(',');

            double x = double.Parse(v[0]), y = double.Parse(v[1]);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
            else if (y == 0)
                Console.WriteLine("Eixo X");
            else if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine("Q1");
                else
                    Console.WriteLine("Q4");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("Q2");
                else
                    Console.WriteLine("Q3");
            }

        }
        public static void questao08()
        {
            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)
                Console.WriteLine("Isento");
            else if (salario <= 3000)
                Console.WriteLine($"Imposto: R${((salario-2000)*.08).ToString("F2",CultureInfo.InvariantCulture)}");
            else if (salario <= 4500)
                Console.WriteLine($"Imposto: R${((salario-3000)*.18+1000*.08).ToString("F2",CultureInfo.InvariantCulture)}");
            else
                Console.WriteLine($"Imposto: R${((salario-4500)*.28+1500*.18+1000*.08).ToString("F2",CultureInfo.InvariantCulture)}");

        }


    }
}