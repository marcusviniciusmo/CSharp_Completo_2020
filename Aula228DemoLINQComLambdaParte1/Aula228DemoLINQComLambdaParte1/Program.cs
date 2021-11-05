using Aula228DemoLINQComLambdaParte1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula228DemoLINQComLambdaParte1
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // TIER 1 AND PRICE < 900.0
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900.0", r1);

            // NAME OF PRODUCTS FROM TOOLS
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", r2);

            // PRODUCTS STARTED WITH 'C' AND ANONYNOUS OBJECT
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("PRODUCTS STARTED WITH 'C' AND ANONYNOUS OBJECT", r3);

            // TIER 1 ORDER BY PRICE THEN BY NAME
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            // SKIP 2 TAKE 4 (pula os 2 primeiros e pega 4)
            var r5 = products.Skip(2).Take(4);
            Print("SKIP 2 TAKE 4", r5);

            // FIRST OR DEFAULT - encontrando um elemento
            var r6 = products.FirstOrDefault();
            Console.WriteLine($"First or Default Test 1: {r6}");
            Console.WriteLine();

            // FIRST OR DEFAULT - não encontrando nenhum elemento
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault(); // se não encontrar nenhum, retorna nulo
            Console.WriteLine($"First or Default Test 2: {r7}");
            Console.WriteLine();

            // SINGLE OR DEFAULT - encontrando um elemento
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or Default Test 1: {r8}");
            Console.WriteLine();

            // SINGLE OR DEFAULT - não encontrando nenhum elemento
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine($"Single or Default Test 2: {r9}");
            Console.WriteLine();

            // MAX
            var r10 = products.Max(p => p.Price);
            Console.WriteLine($"Max price: {r10}");
            Console.WriteLine();

            // MIN
            var r11 = products.Min(p => p.Price);
            Console.WriteLine($"Min price: {r11}");
            Console.WriteLine();

            // CATEGORY 1 SUM PRICES
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 Sum Prices: {r12}");
            Console.WriteLine();

            // CATEGORY 1 AVERAGE PRICES
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average Prices: {r13}");
            Console.WriteLine();

            // CATEGORY 5 AVERAGE EMPTY - coleção vazia e divisão por 0
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 Average Prices: {r14}");
            Console.WriteLine();

            // CATEGORY 1 AGGREGATE
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate Sum: {r15}");
            Console.WriteLine();

            // CATEGORY 5 AGGREGATE
            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 5 Aggregate Sum: {r16}");
            Console.WriteLine();

            // GROUP BY
            var r17 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> item in r17)
            {
                Console.WriteLine($"Category {item.Key.Name}:");
                foreach (Product product in item)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
