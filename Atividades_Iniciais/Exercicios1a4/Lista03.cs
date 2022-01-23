using System;
using System.Globalization;

namespace Course
{
    public class Lista03

    {
        public static void questao01()
        {
            string user_input = "", password = "2002";
            while (user_input != password)
            {
                Console.Write("Senha: ");
                user_input = Console.ReadLine();
                if (user_input != password)
                    Console.WriteLine("Senha Inválida\n");
                else
                    Console.WriteLine("\nAcesso Permitido");
            }
        }
        public static void questao02()
        {
            bool keep_asking = true;
            while (keep_asking)
            {
                Console.Write("Digite as coordenadas \"X,Y\": ");
                string[] v = Console.ReadLine().Split(',');

                double x = double.Parse(v[0]), y = double.Parse(v[1]);

                if (x == 0 || y == 0)
                    keep_asking = false;
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

        }

        public static void questao03()
        {
            char productNumber = ' ';
            int alcool_1 = 0, gas_2 = 0, diesel_3 = 0;
            while (productNumber != '4')
            {
                Console.Write("\nDigite o número do produto: ");
                productNumber = char.Parse(Console.ReadLine());

                switch (productNumber)
                {
                    case '1':
                        alcool_1 += 1;
                        break;
                    case '2':
                        gas_2 += 1;
                        break;
                    case '3':
                        diesel_3 += 1;
                        break;
                    default:
                        break;

                }
            }
            Console.WriteLine($"\nMUITO OBRIGADO\n" +
                $"Alcool: {alcool_1}\n" +
                $"Gasolina: {gas_2}\n" +
                $"Diesel: {diesel_3}\n");

        }


    }
}