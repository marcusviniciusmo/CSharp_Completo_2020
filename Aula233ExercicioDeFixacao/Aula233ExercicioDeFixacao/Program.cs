using Aula233ExercicioDeFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Aula233ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados (nome, email e salário) de funcionários a partir de um arquivo em formato .csv.
             * Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor
             * fornecido pelo usuário. Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.
             */

            string fileName = @"/input.txt";
            Console.Write("Enter full file path: ");
            string path = $"{Console.ReadLine()}{fileName}";

            Console.Write("Enter salary: ");
            double newSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Console.WriteLine($"Email of people whose salary is more than {newSalary.ToString("F2", CultureInfo.InvariantCulture)}:");

                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emails = list.Where(e => e.Salary > newSalary).OrderBy(e => e.Email).Select(e => e.Email);

                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                var sum = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred! {e.Message}");
            }
        }
    }
}
