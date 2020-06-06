using System;
using System.Globalization;

namespace Aula47MembrosEstaticosParte2Solucao3
{
    class Program
    {
        /* Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume
         * de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
         * 
         * Versão 3: classe Calculadora com método estático.
         */

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
