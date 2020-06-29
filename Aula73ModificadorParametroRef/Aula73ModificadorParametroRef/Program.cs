using System;

namespace Aula73ModificadorParametroRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            // Chamada de uma função que não triplica o valor passado como parâmetro.
            Calculator.FuncaoQueNaoTriplica(a);

            Console.WriteLine("Função que não triplica o valor passado como parâmetro.");
            Console.WriteLine(a);

            // Chamada de uma função que triplica o valor passado como parâmetro.
            Calculator.FuncaoQueTriplica(ref a);
            
            Console.WriteLine("Função que triplica o valor passado como parâmetro.");
            Console.WriteLine(a);
        }
    }
}
