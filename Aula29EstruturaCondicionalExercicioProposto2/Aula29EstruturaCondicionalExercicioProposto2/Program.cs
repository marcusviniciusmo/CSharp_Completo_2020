using System;

namespace Aula29EstruturaCondicionalExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Insira um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
