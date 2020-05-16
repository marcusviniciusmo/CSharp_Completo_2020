using System;
using System.Globalization;

namespace Aula32EstruturaRepetitivaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Digitar um número e mostrar sua raiz quadrada com três casas decimais, depois repetir o procedimento. Quando o usuário digitar um número negativo
             * (podendo inclusive, ser na primeira vez), mostrar uma mensagem "Número negativo" e terminar o programa.
             */ 

            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0.0)
            {
                double raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine(raizQuadrada.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture
                    );
            }

            Console.WriteLine("Número negativo!");
        }
    }
}
