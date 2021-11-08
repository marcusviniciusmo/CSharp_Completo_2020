﻿using System;
using System.Linq;

namespace Aula226IntroducaoAoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}