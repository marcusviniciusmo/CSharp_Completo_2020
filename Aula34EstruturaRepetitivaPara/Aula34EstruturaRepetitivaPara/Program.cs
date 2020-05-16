using System;

namespace Aula34EstruturaRepetitivaPara
{
    class Program
    {
        static void Main(string[] args)
        {
            // Digitar um número N e depois N valores inteiros. Mostrar a soma dos N valores digitados.

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int numeroDigitado, soma = 0;

            for (int contador = 1; contador <= N; contador++)
            {
                Console.Write($"Valor #{contador}: ");
                numeroDigitado = int.Parse(Console.ReadLine());

                soma += numeroDigitado;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}
