using System;
using System.Globalization;

namespace Aula24EstruturaSequencialExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
             * a) a área do triângulo retângulo que tem A por base e C por altura.
             * b) a área do círculo de raio C. (pi = 3.14159)
             * c) a área do trapézio que tem A e B por bases e C por altura
             * d) a área do quadrado que tem lado B.
             * e) a área do retângulo que tem lados A e B.
             */

            double valorPi = 3.14159;

            Console.WriteLine("Insira o valor de A:");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de B:");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de C:");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (A * C) / 2;
            double areaCirculo = valorPi * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
