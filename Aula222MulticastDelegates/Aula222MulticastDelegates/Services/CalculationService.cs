using System;

namespace Aula222MulticastDelegates.Services
{
    class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine($"Max: {max}");
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
