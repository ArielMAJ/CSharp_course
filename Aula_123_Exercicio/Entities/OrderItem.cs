using System;
using System.Globalization;

namespace Aula_123_Exercicio.Entities
{
    internal class OrderItem
    {
        public Product OrderProduct { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(Product orderProduct, int quantity, double price)
        {
            OrderProduct = orderProduct;
            Quantity = quantity;
            Price = orderProduct.Price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{OrderProduct.Name}, " +
                $"${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantity: {Quantity}, " +
                $"Subtotal: ${subTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
