using System;
using System.Globalization;

namespace Aula45ClassesAtributosMetodosExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário
             * líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar
             * novamente os dados do funcionário. Use a classe dada como exemplo.
             */

            Funcionario func1 = new Funcionario();

            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {func1}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func1.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {func1}");
        }
    }
}
