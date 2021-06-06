using System;
using System.IO;

namespace Aula186FileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maneira 01 (sem o @ no início, deve-se digitar \\):
            //string sourcePath = "C:\\Users\\marcu\\source\\repos\\Aula186FileFileInfoIOException\\file01.txt";

            // Maneira 02 (com o @ no início):
            string sourcePath = @"C:\Users\marcu\source\repos\Aula186FileFileInfoIOException\file01.txt";
            string targetPath = @"C:\Users\marcu\source\repos\Aula186FileFileInfoIOException\file02.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                Console.WriteLine("Cópia feita com sucesso.");
                Console.WriteLine();

                Console.Write("Fazendo a leitura...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Leitura: ");
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
