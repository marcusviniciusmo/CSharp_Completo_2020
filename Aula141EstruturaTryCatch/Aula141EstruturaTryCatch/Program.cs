using System;

namespace Aula141EstruturaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N1: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("N2: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine();
                int result = n1 / n2;
                Console.Write($"Result N1 / N2: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error! {e.Message}");
            }
        }
    }
}
