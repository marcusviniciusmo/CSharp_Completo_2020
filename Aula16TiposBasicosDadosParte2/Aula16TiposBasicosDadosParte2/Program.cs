using System;

namespace Aula16TiposBasicosDadosParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0046'; // Imprime a letra 'F' usando o código unicode.

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            // FLOAT
            float n5 = 4.5f;
            Console.WriteLine(n5);

            // DOUBLE
            double n6 = 3.1;
            Console.WriteLine(n6);

            // STRING
            string nome = "Maria Green";
            Console.WriteLine(nome);

            // OBJECT
            object obj1 = "Alex Brow";
            object obj2 = 2.5f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // MÍNIMO E MÁXIMO VALOR
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
