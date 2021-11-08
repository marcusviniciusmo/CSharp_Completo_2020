using Aula232ExercicioResolvido.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Aula232ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato .csv
             * (suponha que exista pelo menos um produto). Em seguida mostrar o preço médio dos produtos.
             * Depois, mostrar os nomes, em ordem decrescente, dos produtos que possuem preço inferior ao preço médio.
             */

            string fileName = @"/input.txt";
            Console.Write("Enter full file path: ");
            string path = $"{Console.ReadLine()}{fileName}";

            List<Product> list = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));
                    }
                }

                var average = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

                Console.WriteLine($"Average price: {average.ToString("F2", CultureInfo.InvariantCulture)}");

                var names = list.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);

                foreach (string item in names)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
