using System;
using System.Globalization;

namespace Aula48MembrosEstaticosExercicioProposto
{
    class Program
    {
        /* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
         * Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá de pagar 6% de IOF sobre o 
         * valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
         */
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeComprada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorDeMoeda.ConverterMoeda(cotacao, quantidadeComprada);

            Console.WriteLine($"Valor a ser pago em reais = {valorEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
