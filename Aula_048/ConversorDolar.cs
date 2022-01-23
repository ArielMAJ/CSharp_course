using System;
using System.Globalization;

namespace Course
{
    public class ConversorDolar
    {
        public static double IOF = 6.0 / 100.0;

        public static void Conversao()
        {
            Console.Write("Cotação dollar: ");
            double cot = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Valor Compra: ");
            double valorComprado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Pagar: {(valorComprado*cot*(1+IOF)).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
