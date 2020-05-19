using System;
using System.Globalization;

namespace Aula45ClassesAtributosMetodosExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
             * Usar uma classe como dada no exemplo.
             */

            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo:");
            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"ÁREA = {retangulo1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {retangulo1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
