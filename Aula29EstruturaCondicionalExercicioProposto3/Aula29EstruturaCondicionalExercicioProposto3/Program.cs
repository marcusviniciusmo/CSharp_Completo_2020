using System;

namespace Aula29EstruturaCondicionalExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São Múltiplos" ou "Não são Múltiplos", indicando se os valores lidos
             * são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
             */

            Console.WriteLine("Insira o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B:");
            int B = int.Parse(Console.ReadLine());

            if ((A % B == 0) || (B % A == 0))
                Console.WriteLine("São Múltiplos");
            else
                Console.WriteLine("Não são Múltiplos");
        }
    }
}
