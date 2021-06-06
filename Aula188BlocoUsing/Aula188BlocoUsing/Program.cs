using System;
using System.IO;

namespace Aula188BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\marcu\source\repos\Aula188BlocoUsing\file01.txt";

            // ======================= MODO 01 - MODO EXTENSO

            try
            {
                Console.WriteLine("Modo 01 - Modo extenso:");

                using (FileStream fileStream01 = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader streamReader01 = new StreamReader(fileStream01))
                    {
                        while (!streamReader01.EndOfStream)
                        {
                            string line = streamReader01.ReadLine();
                            Console.WriteLine(line);
                        }

                        Console.WriteLine();
                    }
                }
            }
             catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }

            // ======================= MODO 02 - MODO RESUMIDO

            Console.WriteLine("Modo 02 - Modo resumido:");
            try
            {
                using (StreamReader streamReader02 = File.OpenText(path))
                {
                    while (!streamReader02.EndOfStream)
                    {
                        string line = streamReader02.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
