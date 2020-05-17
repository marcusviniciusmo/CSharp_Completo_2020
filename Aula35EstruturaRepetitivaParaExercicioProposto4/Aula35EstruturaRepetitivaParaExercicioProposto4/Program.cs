using System;
using System.Globalization;

namespace Aula35EstruturaRepetitivaParaExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual zero,
             * mostrar a mensagem "divisão impossível".
             */

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            double divisao;

            for (int contador = 1; contador <= n; contador++)
            {
                Console.Write("Digite o primeiro número do par: ");
                int primeiro = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número do par: ");
                int segundo = int.Parse(Console.ReadLine());

                if (segundo == 0)
                {
                    Console.WriteLine("divisão impossível");
                }
                else
                {
                    divisao = (double)primeiro / segundo;

                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
