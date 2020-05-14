using System;
using System.Globalization;

namespace Aula29EstruturaCondicionalExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor 
             * da conta a pagar
             * 
             * CODIGO       ESPECIFICAÇÃO           PREÇO
             *    1         Cachorro-Quente         R$ 4.00
             *    2         X-Salada                R$ 4.50
             *    3         X-Bacon                 R$ 5.00
             *    4         Torrada Simples         R$ 2.00
             *    5         Refrigerante            R$ 1.50
             */

            Console.WriteLine("Insira o código do produto:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira a quantidade do produto {codigo}:");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = 0.0, total = 0.0;

            if (codigo == 1)
            {
                preco = 4.00;
                total = preco * quantidade;
            }
            else if (codigo == 2)
            {
                preco = 4.50;
                total = preco * quantidade;
            }
            else if (codigo == 3)
            {
                preco = 5.00;
                total = preco * quantidade;
            }
            else if (codigo == 4)
            {
                preco = 2.00;
                total = preco * quantidade;
            }
            else if (codigo == 5)
            {
                preco = 1.50;
                total = preco * quantidade;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
