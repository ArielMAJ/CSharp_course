using System;
using System.Globalization;

namespace Aula_204.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
            private set { }
        }

        public override string? ToString()
        {
            return
                $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
