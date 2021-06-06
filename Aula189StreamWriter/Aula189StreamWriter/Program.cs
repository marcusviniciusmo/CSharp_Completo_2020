using System;
using System.IO;

namespace Aula189StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\marcu\source\repos\Aula189StreamWriter\file01.txt";
            string targetPath = @"C:\Users\marcu\source\repos\Aula189StreamWriter\file02.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                // AppendText - acrescenta um texto ao final do arquivo.
                using (StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    Console.Write("Digite o autor do projeto: ");
                    string nome = Console.ReadLine();
                    streamWriter.WriteLine($"Nome do autor do projeto: {nome}");

                    DateTime now = DateTime.Now;
                    streamWriter.WriteLine($"Realizado em: {now.ToString("dd/MM/yyyy")} às {now.ToString("HH:mm")}.");
                    streamWriter.WriteLine();

                    foreach(string line in lines)
                    {
                        streamWriter.WriteLine(line.ToString().ToUpper());
                    }

                    Console.WriteLine("Escrita feita com sucesso.");
                    Console.WriteLine("Fim do programa.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
