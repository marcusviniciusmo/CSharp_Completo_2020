using System;
using System.Globalization;

namespace Aula38ResolvendoUmProblemaSemOrientacaoAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois
             * triângulos e dizer qual dos dois triângulos possui a maior área.
             * 
             * A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte (fórmula de Heron):
             *         ______________________
             * area = √p(p - a)(p - b)(p - c)           onde p = (a + b + c) / 2
             * 
             * Obs: é usada a fórmula de Heron, pois a altura do triângulo é desconhecida.
             */

            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("a: ");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b: ");
            double bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("c: ");
            double cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Entre com as medidas do tribângulo Y:");
            Console.Write("a: ");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b: ");
            double bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("c: ");
            double cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (aX + bX + cX) / 2;
            double pY = (aY + bY + cY) / 2;

            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));

            Console.WriteLine("");
            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
