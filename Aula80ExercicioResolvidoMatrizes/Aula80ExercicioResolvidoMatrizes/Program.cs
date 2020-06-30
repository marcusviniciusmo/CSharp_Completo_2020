using System;

namespace Aula80ExercicioResolvidoMatrizes
{
    /* Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros. Em seguida, mostrar a diagonal principal
     * e a quantidade de valores negativos da matriz.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz?: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];
            int negative = 0;

            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite os valores da linha {i}: ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                        Console.Write($"{matriz[i,j]} ");

                    if (matriz[i, j] < 0)
                        negative++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Negative number = {negative}");
        }
    }
}
