using System;

namespace Aula15TiposBasicosDadosParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 126; // byte não aceita números negativos e só dentro da faixa de 0 a 255.

            Console.WriteLine(x);
            Console.WriteLine(n1);

            // Overflow
            byte n2 = 255;
            n2++;
            sbyte y = 127;
            y++;

            // Overflow
            Console.WriteLine(n2); // Quando o valor da variável é extrapolado, seu limite vai para o limite oposto. Por isso é exibido o valor 0.
            Console.WriteLine(y); // O limite oposto ao tipo 'sbyte' é -128.

            // Valor máximo de um número inteiro
            int A1 = 1000;
            int A2 = 2147483647;
            long A3 = 2147483648L; // Uma recomendação colocar o L ao final do número para indicar que está trabalhando com uma variável long.

            Console.WriteLine(A1);
            Console.WriteLine(A2);
            Console.WriteLine(A3);
        }
    }
}
