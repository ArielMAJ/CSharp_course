using System;

namespace Aula_137_Exercicio.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenses { get; set; }
        public Individual(string name, double anualIncome, double healthExpenses) : base(name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.00)
                return AnualIncome * 0.15 - HealthExpenses * 0.5;
            else
                return AnualIncome * 0.25 - HealthExpenses * 0.5;
        }
    }
}
