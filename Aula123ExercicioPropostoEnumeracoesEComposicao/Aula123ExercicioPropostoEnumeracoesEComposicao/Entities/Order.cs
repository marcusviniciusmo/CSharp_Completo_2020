using Aula123ExercicioPropostoEnumeracoesEComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula123ExercicioPropostoEnumeracoesEComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("");
            str.AppendLine("ORDER SUMMARY:");
            str.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy  HH:mm:ss")}");
            str.AppendLine($"Order status: {Status}");
            str.AppendLine($"Client: {Client}");
            str.AppendLine("Order items:");
            
            foreach (OrderItem items in Items)
            {
                str.AppendLine($"{items}");
            }

            str.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
