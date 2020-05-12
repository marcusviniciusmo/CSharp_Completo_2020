using System;

namespace Aula24EstruturaSequencialExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D
             * segundo a fórmula: DIFERENCA = (A * B - C * D)
             */

            Console.WriteLine("Digite um valor para A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para D:");
            int D = int.Parse(Console.ReadLine());

            int diferenca = ((A * B) - (C * D));
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
