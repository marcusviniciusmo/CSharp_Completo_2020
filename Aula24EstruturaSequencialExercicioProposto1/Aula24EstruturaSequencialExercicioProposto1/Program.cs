using System;

namespace Aula24EstruturaSequencialExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
             */

            Console.WriteLine("Digite o primeiro valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
