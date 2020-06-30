using System;

namespace Aula79Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine("---------- COMANDO Lenght ----------");
            Console.WriteLine($"Quantos elementos a matriz tem no total: {matriz.Length}");

            Console.WriteLine("---------- COMANDO Rank ----------");
            Console.WriteLine($"A quantidade de linhas da matriz: {matriz.Rank}");

            Console.WriteLine("---------- COMANDO GetLenght ----------");
            Console.WriteLine($"A dimensão {0} tem tamanho {matriz.GetLength(0)}"); // Quantidade de linhas

            Console.WriteLine($"A dimensão {1} tem tamanho {matriz.GetLength(1)}"); // Quantidade de colunas
        }
    }
}
