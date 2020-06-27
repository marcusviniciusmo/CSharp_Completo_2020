using System;

namespace Aula68Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; --> Essa desclaração está incorreta.

            // Nullable<double> x = null; --> Essa declaração está correta, porém ela pode ser simplicada:

            double? x = null;
            double? y = 10.0;

            Console.WriteLine("Método -- GetValueOrDefault:");
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine();
            Console.WriteLine("Método -- HasValue:");
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine();
            Console.WriteLine("Método -- Value:");
            if (x.HasValue)
                Console.WriteLine(x.Value); // Lança uma exceção, pois a variável nullable precisa ter um valor.
            else
                Console.WriteLine("X is null.");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            Console.WriteLine();
            Console.WriteLine("--------------- OPERADOR DE COALESCÊNCIA ---------------");
            double a = x ?? 5;
            double b = y ?? 5;
            double c = x ?? (a * b);
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }
    }
}
