using Aula133ExercicioPropostoHerancaEPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula133ExercicioPropostoHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário).
             * Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem que foram digitados.
             * 
             * Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega,
             * e produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados
             * na etiqueta de preço conforme exemplo. Para produtos importados, a taxa de alfândega deve
             * ser acrescentada ao preço final do produto.
             */

            Console.Write("Enter the name of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.ToString().ToUpper() == "I")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type.ToString().ToUpper() == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
