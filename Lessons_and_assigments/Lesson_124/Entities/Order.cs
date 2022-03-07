using System;
using Aula_115.Entities.Enums;

namespace Aula_115.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus orderStatus { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {orderStatus}";
        }
    }
}
