using System;

namespace Aula73ModificadorParametroOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triplicar(a, out triple);

            Console.WriteLine(triple);
        }
    }
}
