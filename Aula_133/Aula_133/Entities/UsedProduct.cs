using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_133.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate;
        private string _name;

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string Name { get { return _name + " (used)"; } set { _name = value; } }

        public override string PriceTag()
        {
            return base.PriceTag() +
                " (Manufacture date: " +
                ManufactureDate.ToString("dd/MM/yyyy") +
                ")";
        }
    }
}
