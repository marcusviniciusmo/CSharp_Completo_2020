﻿using Aula223PredicateExemploComRemoveAll.Entities;
using System;
using System.Collections.Generic;

namespace Aula223PredicateExemploComRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa que, a partir de uma lista de produtos, remova da lista
             * somente aqueles cujo preço mínimo seja 100.
             */

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
