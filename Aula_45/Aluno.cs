using System;
using System.Globalization;

namespace Course
{
    class Aluno
    {
        string Nome;
        double Nota01;
        double Nota02;
        double Nota03;

        public double NotalFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }
        public bool Aprovado()
        {
            return NotalFinal() >= 60;
        }
        public void AskInfo()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Nota 01: ");
            Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 02: ");
            Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 03: ");
            Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            if (Aprovado())
                return $"\nNome: {Nome}\n" +
                    $"Nota final = {NotalFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                    $"Aprovado!";
            else
                return $"\nNome: {Nome}\n" +
                    $"Nota final = {NotalFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                    $"Reprovado!\n" +
                    $"Faltaram {(60 - NotalFinal()).ToString("F2", CultureInfo.InvariantCulture)} pontos.";
        }
    }
}