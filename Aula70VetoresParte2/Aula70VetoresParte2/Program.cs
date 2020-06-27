using System;
using System.Globalization;

namespace Aula70VetoresParte2
{
    class Program
    {
        /* Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos em um vetor. Em seguida, mostrar o preço
         * médio dos produtos.
         */
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int N = int.Parse(Console.ReadLine());

            Produtos[] prod = new Produtos[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º produto: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite o preço do produto {nome}: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Antes de atribuir valores aos atributos do objeto, é necessário instanciar cada objeto da classe Produtos.
                prod[i] = new Produtos { Nome = nome, Preco = preco}; 
            }

            double soma = 0;

            for (int i = 0; i < N; i++)
            {
                soma += prod[i].Preco;
            }

            double media = soma / N;

            Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
