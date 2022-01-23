using System;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        string Nome;
        double SalarioBruto;
        double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario()
        {
            Console.Write("Porcentagem de aumento: ");
            SalarioBruto *= 1.0+double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)/100.0;
        }
        public void AskInfo()
        {
            Console.Write("\nNome: ");
            Nome = Console.ReadLine();
            
            Console.Write("Salário Bruto: ");
            SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"\nNome: {Nome}\n" +
                $"Salário Líquido = {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}