using System;
using System.Globalization;

namespace Aula87SintaxeAlternativaExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price > 20.0) ? price * 0.10 : price * 0.05;

            Console.WriteLine($"Dicount: US$ {discount.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
 