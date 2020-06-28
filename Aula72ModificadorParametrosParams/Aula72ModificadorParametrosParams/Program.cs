using System;

namespace Aula72ModificadorParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            int result = Calculator.Sum(10, 20, 30, 40);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(result);
        }
    }
}
