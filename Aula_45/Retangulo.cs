using System;
using System.Globalization;

namespace Course
{
    class Retangulo
    {
        double Largura;
        double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public void AskInfo()
        {
            Console.Write("Largura: ");
            Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"\nArea = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Perimetro = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Diagonal = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}