using System;

namespace Aula35EstruturaRepetitivaParaExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= x; contador++)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
