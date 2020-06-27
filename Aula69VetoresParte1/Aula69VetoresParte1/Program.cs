using System;
using System.Globalization;

namespace Aula69VetoresParte1
{
    class Program
    {
        // Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.
         
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidaade de pessoas: ");
            int pessoas = int.Parse(Console.ReadLine());

            double[] alturas = new double[pessoas];

            for (int qtdPessoas = 0; qtdPessoas < pessoas; qtdPessoas++)
            {
                Console.Write($"Digite a altura da {qtdPessoas + 1}ª pessoa: ");
                alturas[qtdPessoas] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < alturas.Length; i++)
            {
                soma += alturas[i];
            }
            
            double media = soma / pessoas;

            Console.WriteLine($"AVERAGE HEIGHT: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
