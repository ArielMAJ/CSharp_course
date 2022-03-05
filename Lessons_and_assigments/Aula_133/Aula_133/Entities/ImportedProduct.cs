using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Aula_133.Entities
{
    internal class ImportedProduct : Product
    {
        private double _price;
        public double CustomFees { get; set; }


        public ImportedProduct(string name, double price, double customFees) : base(name, price)
        {
            CustomFees = customFees;
        }

        public override double Price { get { return _price + CustomFees; } set { _price = value; } }
        public override string PriceTag()
        {
            return base.PriceTag() + 
                " (Custom Fees: $ " +
                CustomFees.ToString("F2", CultureInfo.InvariantCulture) +
                ")";
        }
    }
}
