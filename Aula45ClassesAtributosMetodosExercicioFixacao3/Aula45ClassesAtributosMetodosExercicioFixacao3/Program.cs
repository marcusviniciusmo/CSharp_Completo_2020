using System;
using System.Globalization;

namespace Aula45ClassesAtributosMetodosExercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo
             * e o terceiro valem 35 cada). Ao final, mostrar qual nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso 
             * negativo, quantos pontos faltam para o aluno obter o mínimo para sere aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
             * este problema.
             */

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.CalcularPontosRestantes().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
