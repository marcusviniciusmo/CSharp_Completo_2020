using System;
using System.Globalization;

namespace Aula24EstruturaSequencialExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse
             * funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
             */

            Console.WriteLine("Insira o número do funcionário:");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira o número de horas trabalhadas pelo funcionário {numeroFuncionario}");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira o valor que o funcionário {numeroFuncionario} recebe por hora trabalhadas:");
            float valorHorasTrabalhadas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = horasTrabalhadas * valorHorasTrabalhadas;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
