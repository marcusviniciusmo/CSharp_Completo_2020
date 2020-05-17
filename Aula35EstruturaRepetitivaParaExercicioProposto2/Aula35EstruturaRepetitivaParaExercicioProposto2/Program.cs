using System;

namespace Aula35EstruturaRepetitivaParaExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro
             * do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e
             * "out" para fora do intervalo).
             */

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0, numeroDigitado = 0;

            for (int contador = 1; contador <= n; contador++)
            {
                Console.Write($"Digite o {contador}º número: ");
                numeroDigitado = int.Parse(Console.ReadLine());

                if ((numeroDigitado >= 10) && (numeroDigitado <= 20))
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
