using System;
using System.Globalization;

namespace Aula24EstruturaSequencialExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
             * 
             * Fórmula da área: area = π . raio²
             * 
             * Considere o valor de π = 3.14159
             */

            double valorPi = 3.14159;
            Console.WriteLine("Digite o valor do raio do círculo:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = valorPi * Math.Pow(raio, 2);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
