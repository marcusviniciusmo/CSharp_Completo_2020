using System;

namespace Aula20OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            // ATRIBUIÇÃO CUMULATIVA
            a += 2; // a RECEBE a + 2;
            Console.WriteLine(a);

            a *= 3; // a RECEBE a * 3;
            Console.WriteLine(a);

            a -= 3; // a RECEBE a - 3;
            Console.WriteLine(a);

            a /= 3; // a RECEBE a / 3;
            Console.WriteLine(a);

            a %= 5; // a RECEBE a % 5;
            Console.WriteLine(a);

            // CONCATENAÇÃO CUMULATIVA EM STRINGS
            string x = "ABC";
            Console.WriteLine(x);
            x += "DEF";
            Console.WriteLine(x);

            // OPERADORES ARITMÉTICOS / ATRIBUIÇÃO
            int b = 10, c = 9;
            b++;
            c--;
            Console.WriteLine(b);
            Console.WriteLine(c);

            int x1 = 10;
            int x2 = x1++; // Atribui o valor de x1 para a variável x2, e depois incrementa a variável x1.
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            int x3 = 20;
            int x4 = ++x3; // Incrementa o valor de x3, e depois atribui o valor de x3 para a variável x4.
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
    }
}
