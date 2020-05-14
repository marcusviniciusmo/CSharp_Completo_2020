using System;
using System.Globalization;

namespace Aula29EstruturaCondicionalExercicioProposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir,            |y
             * qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).             Q2   |    Q1
             *                                                                                                                         ________|________
             * Se o ponto estiver na origem, escreva a mensagem "Origem".                                                                      |        x
             *                                                                                                                            Q3   |    Q4
             * Se o ponto estiver sobre um dos eixos, escreva "Eixo X" ou "Eixo Y", conforme for a situação.                                   |
             */                                           
             
            Console.WriteLine("Insira o valor de x:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de y:");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((x != 0) && (y != 0))
            {
                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("Q1");
                }
                else if ((x > 0) && (y < 0))
                {
                    Console.WriteLine("Q4");
                }
                else if ((x < 0) && (y > 0))
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
            else if ((x == 0) && (y != 0))
            {
                Console.WriteLine("Eixo y");
            }
            else if ((x != 0) && (y == 0))
            {
                Console.WriteLine("Eixo x");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
