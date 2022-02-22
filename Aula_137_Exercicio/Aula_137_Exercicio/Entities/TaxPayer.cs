using System;

namespace Aula_137_Exercicio.Entities
{
    abstract internal class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        abstract public double TaxesPaid();


    }
}
