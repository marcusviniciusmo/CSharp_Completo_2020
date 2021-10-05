﻿using System;
using System.Globalization;
using System.Text;

namespace Aula206RestricoesDeGenerics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}");

            return str.ToString();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not a Product");
            }

            Product otherProduct = obj as Product;

            return Price.CompareTo(otherProduct.Price);
        }
    }
}
