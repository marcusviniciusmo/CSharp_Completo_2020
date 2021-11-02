using System;
using System.Collections.Generic;
using System.IO;

namespace Aula214ExercicioPropostoSobreDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Na contagem de votos de uma eleição, são gerados vários registros de votação contendo o nome do candidato
             * e a quantidade de votos (formato .csv) que ele obteve em uma urna de votação. Você deve fazer um programa
             * para ler os registros de votação a partir de um arquivo, e daí gerar um relatório consolidado com os totais
             * de cada candidato.
             */

            string fileName = @"\input.txt";
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText($"{path}{fileName}"))
                {
                    Dictionary<string, int> candidates = new Dictionary<string, int>();

                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int vote = int.Parse(line[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += vote;
                        }
                        else
                        {
                            candidates[name] = vote;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in candidates)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                throw new IOException($"An error ocurred! {e.Message}");
            }
        }
    }
}
