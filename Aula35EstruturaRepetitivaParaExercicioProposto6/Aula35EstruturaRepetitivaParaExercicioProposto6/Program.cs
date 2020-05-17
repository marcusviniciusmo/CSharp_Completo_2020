using System;

namespace Aula35EstruturaRepetitivaParaExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler um número inteiro N e calcular todos os seus divisores.

            Console.Write("Digite um valor para N: ");
            int n = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= n; cont++)
            {
                if (n % cont == 0)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
}
