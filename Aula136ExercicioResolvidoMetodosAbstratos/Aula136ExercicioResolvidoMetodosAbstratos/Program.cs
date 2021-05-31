using Aula136ExercicioResolvidoMetodosAbstratos.Entities;
using Aula136ExercicioResolvidoMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula136ExercicioResolvidoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados de N figuras (N fornecido pelo usuário),
             * e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.
             */

            Console.Write("Enter the number os shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shape.ToString().ToUpper() == "R")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else if (shape.ToString().ToUpper() == "C")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
