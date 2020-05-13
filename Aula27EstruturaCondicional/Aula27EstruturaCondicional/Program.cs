using System;

namespace Aula27EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA CONDICIONAL SIMPLES
            int x = 10;
            
            Console.WriteLine("Bom dia");

            if (x < 5)
            {
                Console.WriteLine("Boa tarde");
            }
            
            Console.WriteLine("Boa noite");

            // ESTRUTURA CONDICIONAL COMPOSTA
            Console.WriteLine("Entre com um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar");
            }
        }
    }
}
