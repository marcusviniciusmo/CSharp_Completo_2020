using Aula115Enumeracoes.Entities;
using Aula115Enumeracoes.Entities.Enums;
using System;

namespace Aula115Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine("ENUMERAÇÕES");
            Console.WriteLine(order);

            // CONVERSÃO DE ENUMERAÇÃO PARA STRING

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine();
            Console.WriteLine("CONVERSÃO DE ENUMERAÇÃO PARA STRING");
            Console.WriteLine(txt);

            // CONVERSÃO DE STRING PARA ENUMERAÇÃO

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            
            Console.WriteLine();
            Console.WriteLine("CONVERSÃO DE STRING PARA ENUMERAÇÃO");
            Console.WriteLine(os);
        }
    }
}
