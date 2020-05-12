using System;

namespace Aula21ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONVERSÃO IMPLÍCITA
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            // CASTING
            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            c = (int)a;

            Console.WriteLine(b);
            Console.WriteLine(c);

            int x1 = 5;
            int x2 = 2;

            double resultado = (double)x1 / x2;
            Console.WriteLine(resultado);
        }
    }
}
