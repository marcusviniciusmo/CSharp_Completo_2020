using System;

namespace Aula92OperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("---------- OPERAÇÕES ----------");

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            Console.WriteLine($"T1: {t1}");
            Console.WriteLine($"T2: {t2}");

            TimeSpan sum = t1.Add(t2);
            Console.WriteLine($"Soma: {sum}");

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);

            TimeSpan mult = t2.Multiply(2.0);
            Console.WriteLine(mult);

            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(div);
        }
    }
}
