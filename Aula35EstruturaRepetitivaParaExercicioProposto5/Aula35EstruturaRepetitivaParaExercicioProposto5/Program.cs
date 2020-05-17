using System;

namespace Aula35EstruturaRepetitivaParaExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... * 1. Lembrando que, fatorial de 0 é 1.

            Console.Write("De qual número você deseja saber o fatorial?: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int cont = numero; cont >= 1; cont--)
            {
                fatorial *= cont;
            }

            Console.WriteLine(fatorial);
        }
    }
}
