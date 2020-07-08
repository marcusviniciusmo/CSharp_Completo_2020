using System;

namespace Aula91PropriedadesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
    
            Console.WriteLine("---------- PROPRIEDADES DATETIME ----------");
            Console.WriteLine(date1);
            Console.WriteLine($"1) Date: {date1.Date}");
            Console.WriteLine($"2) Day: {date1.Day}");
            Console.WriteLine($"3) DayOfWeek: {date1.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {date1.DayOfYear}");
            Console.WriteLine($"5) Hour: {date1.Hour}");
            Console.WriteLine($"6) Kind: {date1.Kind}");
            Console.WriteLine($"7) Milisecond: {date1.Millisecond}");
            Console.WriteLine($"8) Minute: {date1.Minute}");
            Console.WriteLine($"9) Month: {date1.Month}");
            Console.WriteLine($"10) Second: {date1.Second}");
            Console.WriteLine($"11) Ticks: {date1.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {date1.TimeOfDay}");
            Console.WriteLine($"13) Year: {date1.Year}");
    
            Console.WriteLine();
            Console.WriteLine("---------- FORMATAÇÕES DATETIME ----------");
            DateTime date2 = new DateTime(2020, 7, 8, 12, 00, 55);
    
            Console.WriteLine(date2.ToLongDateString());
    
            string s2 = date2.ToLongTimeString();
            Console.WriteLine(s2);
    
            string s3 = date2.ToShortDateString();
            Console.WriteLine(s3);
    
            string s4 = date2.ToShortTimeString();
            Console.WriteLine(s4);
    
            string s5 = date2.ToString();
            Console.WriteLine(s5);
    
            Console.WriteLine();
            Console.WriteLine("---------- MÁSCARA DE FORMATAÇÃO ----------");
    
            string s6 = date2.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);
    
            string s7 = date2.ToString("yyyy-MM-dd HH:mm:ss:fff");
            Console.WriteLine(s7);
        }
    }
 }
