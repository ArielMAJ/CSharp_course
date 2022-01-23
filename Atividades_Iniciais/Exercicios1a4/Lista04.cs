using System;
using System.Globalization;

namespace Course
{
    public class Lista04
    {
        public static void questao01()
        {
            Console.Write("Digite um valor inteiro [1,1000]: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void questao02()
        {
            Console.Write("Quantos valores serão lidos?: ");
            int in_the_interval = 0, out_of_the_interval = 0, n = int.Parse(Console.ReadLine());
            int user_input;
            for (int i = 0; i < n; i++)
            {
                user_input = int.Parse(Console.ReadLine());
                if (user_input >= 10 && user_input <= 20)
                    in_the_interval++;
                else
                    out_of_the_interval++;
            }
            Console.WriteLine($"\n{in_the_interval} in\n{out_of_the_interval} out");
        }
        public static void questao03()
        {
            Console.Write("Quantos casos serão calculados?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nDigite os 3 valores separados por vírgula: ");
                string[] user_input = Console.ReadLine().Split(",");

                double a = double.Parse(user_input[0], CultureInfo.InvariantCulture);
                double b = double.Parse(user_input[1], CultureInfo.InvariantCulture);
                double c = double.Parse(user_input[2], CultureInfo.InvariantCulture);
                Console.WriteLine($"\nMédia Ponderada: {((2 * a + 3 * b + 5 * c) / 10).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }

        public static void questao04()
        {
            Console.Write("Número de operações: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nDigite a divisão (Ex.: num/den): ");
                string[] user_input = Console.ReadLine().Split("/");

                double num = double.Parse(user_input[0], CultureInfo.InvariantCulture);
                double den = double.Parse(user_input[1], CultureInfo.InvariantCulture);
                if (den == 0)
                    Console.WriteLine("Divisão impossível.");
                else
                    Console.WriteLine($"Resultado: {(num / den).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
        public static void questao05()
        {
            Console.Write("Calcular o fatorial de: ");
            int fact = 1, n = int.Parse(Console.ReadLine());

            for (int i = n; i > 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }


}
