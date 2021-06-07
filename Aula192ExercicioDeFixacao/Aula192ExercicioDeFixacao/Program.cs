using Aula192ExercicioDeFixacao.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Aula192ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos.
             * Cada item possui um nome, preço unitário e quantidade, separados por vírgula.
             * Você deve gerar um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out"
             * a partir da pasta original do arquivo de origem, contendo apenas o nome e o valor total para aquele item
             * (preço unitário multiplicado pela quantidade), conforme exemplo.
             */

            Console.WriteLine("Enter the file full path (including file and extension):");
            string sourceFilePath = Console.ReadLine();
            //string sourceFilePath = @"C:\Users\marcu\source\repos\Aula192ExercicioDeFixacao\example.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string newFolder = @"out";
                string separator = @$"{Path.DirectorySeparatorChar}";
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetPath = @$"{sourceFolderPath}{separator}{newFolder}";
                string newFile = "summary.csv";

                Directory.CreateDirectory(@$"{targetPath}");

                using (StreamWriter streamWriter = File.AppendText(@$"{targetPath}{separator}{newFile}"))
                {
                    foreach (var line in lines)
                    {
                        string[] separateData = line.Split(';');

                        string name = separateData[0];
                        double price = double.Parse(separateData[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(separateData[2]);

                        Product product = new Product(name, price, quantity);

                        streamWriter.WriteLine($"{product.Name}, {product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }

                    Console.WriteLine($"Arquivo {newFile} gerado com sucesso.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
