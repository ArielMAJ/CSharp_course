using System;
using System.Text;
using Aula_123_Exercicio.Entities.Enums;

namespace Aula_123_Exercicio.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(Client client, OrderStatus status)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double totalPrice = 0;
            foreach(OrderItem item in Items)
            {
                totalPrice += item.subTotal();
            }
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem oItem in Items)
            {
                sb.AppendLine(oItem.ToString());
            }
            sb.Append("Total price: $");
            sb.Append(total().ToString("F2",System.Globalization.CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
