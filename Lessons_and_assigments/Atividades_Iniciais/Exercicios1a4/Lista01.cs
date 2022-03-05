using System;
using System.Globalization;

namespace Course
{
    public class Lista01

    {
        public static void questao01()
        {
            Console.WriteLine("Digite dois inteiros e aperte enter depois de cada:");
            int x = int.Parse(Console.ReadLine()); // 0
            int y = int.Parse(Console.ReadLine()); // 0
            Console.WriteLine($"\nSOMA = {x + y}"); // 0
        }
        public static void questao02()
        {
            Console.Write("\nDigite o valor do raio: ");
            double PI = 3.14159;
            double r = double.Parse(Console.ReadLine()); //100,64
            Console.WriteLine($"A = {PI * Math.Pow(r, 2):0.####}"); //31819.3103
        }
        public static void questao03()
        {
            Console.WriteLine("\nDigite os quatro valores: ");
            int A = int.Parse(Console.ReadLine()); //5
            int B = int.Parse(Console.ReadLine()); //6
            int C = int.Parse(Console.ReadLine()); //-7
            int D = int.Parse(Console.ReadLine()); //8
            Console.WriteLine($"A = {(A * B - C * D)}"); //86
        }
        public static void questao04()
        {
            Console.Write("\nDigite o número do funcionário: ");
            int nFuncionario = int.Parse(Console.ReadLine()); //6
            Console.Write("Digite o número de horas trabalhadas: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine()); //145
            Console.Write("Digite o valor que recebe por hora: ");
            double valorHora = double.Parse(Console.ReadLine()); //15,55

            Console.WriteLine($"NUMBER = {nFuncionario}\nSalary = {horasTrabalhadas * valorHora}"); //6 e 2254.75
        }
        public static void questao05()
        {
            Console.Write("\nDigite o código, quantidade e o valor unitário da peça (separado por vírgulas): ");
            string[] vect01 = Console.ReadLine().Split(','); //13,2,15.30
            Console.Write("\nDigite o código, quantidade e o valor unitário da peça (separado por vírgulas): ");
            string[] vect02 = Console.ReadLine().Split(','); //161,4,5.20

            double valor01 = double.Parse(vect01[1], CultureInfo.InvariantCulture) * double.Parse(vect01[2], CultureInfo.InvariantCulture);
            double valor02 = double.Parse(vect02[1], CultureInfo.InvariantCulture) * double.Parse(vect02[2], CultureInfo.InvariantCulture);


            Console.WriteLine($"VALOR A PAGAR: {(valor01 + valor02).ToString("F2", CultureInfo.InvariantCulture)}"); //51.40
        }
        public static void questao06()
        {
            /*3.0 4.0 5.2
            TRIANGULO: 7.800
            CIRCULO: 84.949
            TRAPEZIO: 18.200
            QUADRADO: 16.000
            RETANGULO: 12.000*/

            Console.Write("\nDigite três valores separados por vírgula: ");
            string[] vect01 = Console.ReadLine().Split(','); //3.0 4.0 5.2

            double a = double.Parse(vect01[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vect01[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vect01[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"TRIANGULO {(a * c / 2.0).ToString("F3", CultureInfo.InvariantCulture)}" +
                $"\nCIRCULO: {(Math.Pow(c, 2) * 3.14159).ToString("F3", CultureInfo.InvariantCulture)}" +
                $"\nTRAPEZIO: {((a + b) * c / 2.0).ToString("F3", CultureInfo.InvariantCulture)}" +
                $"\nQUADRADO: {Math.Pow(b, 2).ToString("F3", CultureInfo.InvariantCulture)}" +
                $"\nRETANGULO: {(a * b).ToString("F3", CultureInfo.InvariantCulture)}");
        }


    }
}