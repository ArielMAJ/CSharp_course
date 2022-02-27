using System;
using System.Globalization;

namespace Aula_192.Entities
{
    internal class ProductSalesSummary
    {
        public Product product { get; set; }
        public int QuantitySold { get; set; }

        public ProductSalesSummary(Product product, int quantitySold)
        {
            this.product = product;
            QuantitySold = quantitySold;
        }

        public double TotalSale()
        {
            return product.Price* QuantitySold;
        }
        public string Summary()
        {

            return $"{product.Name},{TotalSale().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
