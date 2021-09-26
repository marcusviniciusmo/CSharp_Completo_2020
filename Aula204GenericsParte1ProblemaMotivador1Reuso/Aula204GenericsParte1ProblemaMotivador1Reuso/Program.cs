﻿using Aula204GenericsParte1ProblemaMotivador1Reuso.Services;
using System;

namespace Aula204GenericsParte1ProblemaMotivador1Reuso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de 1 a 10),
             * e depois imprima esses números de forma organizada conforme exemplo.
             * Em seguida, informar qual foi o primeiro valor informado.
             */

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
