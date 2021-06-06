using System;
using System.Collections.Generic;
using System.IO;

namespace Aula190DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\marcu\source\repos\Aula190DirectoryDirectoryInfo\myFolders";

            try
            {
                // Listar todas as subpastas a patir da pasta indicada no path.
                IEnumerable<string> allFolders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string str in allFolders)
                {
                    Console.WriteLine(str);
                }

                Console.WriteLine();
                // Listar todos os arquivos (tipo .txt) a partir de uma pasta indicada.
                IEnumerable<string> allFiles = Directory.EnumerateFiles(path, "*.txt", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string str in allFiles)
                {
                    Console.WriteLine(str);
                }

                // Criando uma pasta
                Directory.CreateDirectory(@$"{path}\newFolder\newFolder2");
                Console.WriteLine("Pasta criada com sucesso");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
