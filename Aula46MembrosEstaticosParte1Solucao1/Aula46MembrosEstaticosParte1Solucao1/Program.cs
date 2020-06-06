using System;
using System.Globalization;

namespace Aula46MembrosEstaticosParte1Solucao1
{
    class Program
    {
        /* Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume
             * de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
             * 
             * Versão 1: métodos na própria classe do programa
             *  - NOTA: dentro de um método estático você não pode chamar membros de instância da mesma classe.
            */

        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raior: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
