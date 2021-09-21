using Aula202InterfaceIComparableProblemaMotivador2.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula202InterfaceIComparableProblemaMotivador2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa para ler um arquivo contendo funcionários (nome e salário) no formato .csv,
             * armazenando-os em uma lista. Depois, ordenar a lista por nome e mostrar o resultado na tela.
             * Nota: o caminho do arquivo pode ser informado "hardcode".
             */

            string path = @"C:\Users\marcu\source\repos\Aula202InterfaceIComparableProblemaMotivador2\ProblemaMotivador2.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
