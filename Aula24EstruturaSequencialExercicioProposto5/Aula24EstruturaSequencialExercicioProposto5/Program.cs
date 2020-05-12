using System;
using System.Globalization;

namespace Aula24EstruturaSequencialExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de
             * peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             */

            Console.WriteLine("Insira o código da peça 1:");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de peças 1:");
            int quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário da peça 1:");
            float valor1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o código da peça 2:");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de peças 2:");
            int quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitário da peça 2:");
            float valor2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float total1 = valor1 * quantidade1;
            float total2 = valor2 * quantidade2;
            float total = total1 + total2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
