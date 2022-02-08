using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_133.Entities
{
    internal class Product
    {

        public virtual string Name { get; set; }
        public virtual double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name +
                " $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
