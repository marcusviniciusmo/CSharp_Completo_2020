using System;

namespace Aula35EstruturaRepetitivaParaExercicioProposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, 
             * mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
             */
            
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= n; contador++)
            {
                Console.WriteLine($"{contador} {Math.Pow(contador, 2)} {Math.Pow(contador, 3)}");
            }
        }
    }
}
