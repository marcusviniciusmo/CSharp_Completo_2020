using Aula221IntroducaoADelegates.Services;
using System;

namespace Aula221IntroducaoADelegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double SingleNumericOperation(double n1);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine();

            BinaryNumericOperation op1 = CalculationService.Max;
            BinaryNumericOperation op2 = CalculationService.Sum;
            SingleNumericOperation op3 = CalculationService.Square;

            double result1 = op1(a, b);
            double result2 = op2(a, b);
            double result3 = op3(a);

            Console.WriteLine($"Max: {result1}");
            Console.WriteLine($"Sum: {result2}");
            Console.WriteLine($"Square: {result3}");
        }
    }
}
