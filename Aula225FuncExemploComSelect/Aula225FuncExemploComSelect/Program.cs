﻿using Aula225FuncExemploComSelect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula225FuncExemploComSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista
             * contendo os nomes dos produtos em caixa alta.
             */

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
