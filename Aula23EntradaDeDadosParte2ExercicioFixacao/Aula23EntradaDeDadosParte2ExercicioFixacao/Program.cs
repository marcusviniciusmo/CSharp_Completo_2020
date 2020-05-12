using System;
using System.Globalization;

namespace Aula23EntradaDeDadosParte2ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
             * 
             * Entre com seu nome completo:
             * Alex Green
             * Quantos quartos tem na sua casa?
             * 3
             * Entre com o preço de um produto:
             * 500.50
             * Entre com seu último nome, idade e altura (mesma linha):
             * Green 21 1.73
             * 
             * Saída Esperada (Números reais com duas casas decimais):
             * Alex Green
             * 3
             * 500.50
             * Green
             * 21
             * 1.73
             */

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            byte quartos = byte.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            byte idade = byte.Parse(vet[1]);
            float altura = float.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
