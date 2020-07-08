using System;

namespace Aula91OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();

            DateTime date2 = date1.AddHours(2);
            DateTime date3 = date1.AddMinutes(5);
            DateTime date4 = date1.AddDays(7);

            Console.WriteLine($"Original: {date1}");
            Console.WriteLine($"+ 2 horas: {date2}");
            Console.WriteLine($"+ 5 minutos: {date3}");
            Console.WriteLine($"+ 7 dias: {date4}");

            Console.WriteLine();
            Console.WriteLine("---------- DIFERENÇA ENTRE DATAS ----------");
            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan dif = d2.Subtract(d1);
            Console.WriteLine(dif);
            Console.WriteLine($"{dif.Days} dias de diferença");
        }
    }
}
