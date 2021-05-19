using Aula123ExercicioPropostoEnumeracoesEComposicao.Entities;
using Aula123ExercicioPropostoEnumeracoesEComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace Aula123ExercicioPropostoEnumeracoesEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler os dados de um pedido com N itens (N fornecedio pelo usuário). Depois, mostrar um sumário do pedido conforme exemplo.
            // Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now.

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numberOfItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderitem = new OrderItem(quantity, price, product);

                order.AddItem(orderitem);
            }

            Console.WriteLine(order);
        }
    }
}
