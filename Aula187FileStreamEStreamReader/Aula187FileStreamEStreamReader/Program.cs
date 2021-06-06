using System;
using System.IO;

namespace Aula187FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\marcu\source\repos\Aula187FileStreamEStreamReader\file01.txt";

            // ============================= MODO 01 - NÃO RESUMIDO
            /*
             * Instanciar 2 objetos, é comum na maioria das linguagens modernas. Uma stream genérico que não faz nenhum tratamento de IO,
             * e outra stream específica.
             */

            FileStream fileStream01 = null;
            StreamReader streamReader01 = null;

            try
            {
                fileStream01 = new FileStream(path, FileMode.Open);
                streamReader01 = new StreamReader(fileStream01);

                // Poderia ser feito em uma linha, porém é um método ruim para fechar a conexão depois, sem uma referência.
                //streamReader01 = new StreamReader(new FileStream(path, FileMode.Open));

                Console.WriteLine("Utilzando o modo 01 - Modo extenso e lendo apenas uma linha do arquivo:");
                string line = streamReader01.ReadLine();
                Console.WriteLine(line);
                Console.WriteLine();
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
            finally{
                if (streamReader01 != null) streamReader01.Close();
                if (fileStream01 != null) fileStream01.Close();
            }

            // ============================= MODO 02 - RESUMIDO
            // Instanciar o StreamReader utilizando a classe File como auxiliar.

            StreamReader streamReader02 = null;

            try
            {
                streamReader02 = File.OpenText(path);

                Console.WriteLine("Utilizando o modo 02 - Modo resumido e lendo todas as linhas do arquivo:");
                
                // Ler todas linhas do arquivo
                while (!streamReader02.EndOfStream)
                {
                    string line = streamReader02.ReadLine();
                    Console.WriteLine(line);
                }

                Console.WriteLine();
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
            finally
            {
                if (streamReader02 != null) streamReader02.Close();
            }
        }
    }
}
