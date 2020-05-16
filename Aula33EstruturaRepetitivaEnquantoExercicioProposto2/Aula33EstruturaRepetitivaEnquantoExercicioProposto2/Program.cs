using System;

namespace Aula33EstruturaRepetitivaEnquantoExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa para ler as coordenas (X, Y) de um quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante
             * a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
             */

            Console.Write("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            double y = double.Parse(Console.ReadLine());

            while ((x != 0) && (y != 0))
            {
                if ((x > 0) & (y > 0))
                {
                    Console.WriteLine("primeiro");
                }
                else if ((x > 0) && (y < 0))
                {
                    Console.WriteLine("quarto");
                }
                else if (y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    Console.WriteLine("terceiro");
                }

                Console.WriteLine("");
                Console.Write("Digite o valor de X: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de Y: ");
                y = double.Parse(Console.ReadLine());
            }
        }
    }
}
