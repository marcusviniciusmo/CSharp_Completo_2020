using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula78ExercicioFixacaoListas
{
    class Program
    {
        /* Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id.
         * 
         * Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X. 
         * Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
         * 
         * Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. Um salário só pode ser aumentado
         * com base em uma operação de aumento por porcentagem dada.
         */
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?: ");
            int qtdFuncionario = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < qtdFuncionario; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee: #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployee.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee Id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee employee = listEmployee.Find(x => x.Id == idIncrease);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee item in listEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
