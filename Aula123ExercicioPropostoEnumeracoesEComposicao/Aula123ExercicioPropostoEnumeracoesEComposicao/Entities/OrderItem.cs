using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula123ExercicioPropostoEnumeracoesEComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{Product.Name},");
            str.Append($" ${Price.ToString("F2", CultureInfo.InvariantCulture)},");
            str.Append($" Quantity: {Quantity},");
            str.Append($" Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }
    }
}
