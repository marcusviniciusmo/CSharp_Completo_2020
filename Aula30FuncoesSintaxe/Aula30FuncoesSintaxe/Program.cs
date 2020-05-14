using System;

namespace Aula30FuncoesSintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.

            Console.WriteLine("Insirta o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número:");
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior número digitado foi {resultado}");
        }

        static int Maior(int a, int b, int c)
        {
            int maior;

            if ((a > b) && (a > c))
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}
