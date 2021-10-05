using Aula206RestricoesDeGenerics.Entities;
using Aula206RestricoesDeGenerics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula206RestricoesDeGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uma empresa de consultoria deseja avaliar a performance de produtos, funcionários,
             * dentre outras coisas. Um dos cálculos que ela precisa é encontrar o maior dentre um
             * conjunto de elementos. Fazer um programa que leia um conjunto de N produtos,
             * conforme exemplo, e depois mostre o mais caro deles.
             */

            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}
