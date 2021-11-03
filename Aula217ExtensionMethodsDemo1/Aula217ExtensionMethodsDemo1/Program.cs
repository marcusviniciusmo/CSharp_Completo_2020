using Aula217ExtensionMethodsDemo1.Extensions;
using System;

namespace Aula217ExtensionMethodsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para apresentar um objeto DateTime
             * na forma de tempo decorrido, podendo ser em horas (se menor que 24h) ou em dias caso contrário.
             */

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
