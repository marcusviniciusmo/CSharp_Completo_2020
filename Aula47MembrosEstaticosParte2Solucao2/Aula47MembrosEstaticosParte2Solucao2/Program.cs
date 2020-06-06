using System;
using System.Globalization;

namespace Aula47MembrosEstaticosParte2Solucao2
{
    class Program
    {
        /* Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume
         * de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
         * 
         * Versão 2: classe Calculadora com membros de instância.
         */

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calculadora.Circunferencia(raio);
            double vol = calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
