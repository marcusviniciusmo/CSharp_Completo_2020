using System;

namespace Aula207GetHashCodeEEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===  Equals  ===");
            Console.WriteLine();

            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine();

            string c = "Maria";

            Console.WriteLine(a.Equals(c));

            Console.WriteLine();
            Console.WriteLine("===  GetHashCode  ===");
            Console.WriteLine();

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine();

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(c.GetHashCode());
        }
    }
}
