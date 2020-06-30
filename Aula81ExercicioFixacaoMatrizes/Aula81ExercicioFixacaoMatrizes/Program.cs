using System;

namespace Aula81ExercicioFixacaoMatrizes
{
    class Program
    {
        /* Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros,
         * podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores à
         * esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
         */
        static void Main(string[] args)
        {
            Console.Write("Digite a ordem da matriz: ");
            string[] ordem = Console.ReadLine().Split(' ');
            int M = int.Parse(ordem[0]);
            int N = int.Parse(ordem[1]);

            int[,] matriz = new int[M, N];

            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                Console.Write($"Digite os números da linha {i}: ");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número da matriz: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i,j] == number)
                    {
                        Console.WriteLine($"Position: {i},{j}:");

                        if (j > 0)
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");

                        if (i > 0)
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");

                        if (j < (N - 1))
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");

                        if (i < (M + 1))
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                    }
                }
            }
        }
    }
}
