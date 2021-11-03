using Aula217ExtensionMethodsDemo2.Extensions;
using System;

namespace Aula217ExtensionMethodsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vamos criar um extension method chamado "Cut(int)" na classe String para receber um valor inteiro
             * como parâmetro e gerar um recorte do string original daquele tamanho.
             */

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
