using System;
using System.Globalization;

namespace Aula89DateTimeRepresentandoDataEHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            Console.WriteLine();
            Console.WriteLine("---------- CONSTRUTORES ----------");
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();
            Console.WriteLine("---------- BUILDERS ----------");
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today; // Horário atual, mas com a hora zerada
            DateTime d6 = DateTime.UtcNow; // Horário em relação ao hoário global.

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine();
            Console.WriteLine("---------- PARSE ----------");
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:48");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            Console.WriteLine();
            Console.WriteLine("---------- ParseExact ----------"); // O segundo parâmetro é uma máscara para indicar a formação
            DateTime d11 = DateTime.ParseExact("2020-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
