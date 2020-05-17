using System;
using System.Globalization;

namespace Aula35EstruturaRepetitivaParaExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia 1 valor inteirno N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles
             * com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor
             * tem peso 3 e o terceiro valor tem peso 5.
             */

            Console.Write("Digite o valor de número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());

            string valoresAgrupados;
            string[] valoresSeparados;

            double[] valoresConvertidos = { 0.0, 0.0, 0.0 };

            double mediaPonderada;

            for (int contCasos = 1; contCasos <= n; contCasos++)
            {
                Console.Write($"Digite o valor do {contCasos}º Teste: ");
                valoresAgrupados = Console.ReadLine();

                valoresSeparados = valoresAgrupados.Split(' ');

                for (int contConverter = 0; contConverter < n; contConverter++)
                {
                    valoresConvertidos[contConverter] = double.Parse(valoresSeparados[contConverter], CultureInfo.InvariantCulture);
                }

                mediaPonderada = ((valoresConvertidos[0] * 2) + (valoresConvertidos[1] * 3) + (valoresConvertidos[2] * 5)) / 10;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }   
        }
    }
}
