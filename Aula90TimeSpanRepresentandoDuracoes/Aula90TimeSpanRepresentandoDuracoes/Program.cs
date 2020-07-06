using System;

namespace Aula90TimeSpanRepresentandoDuracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30); // Parâmetro(hora, minuto, segundo)

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            Console.WriteLine("---------- CONSTRUTORES ----------");
            TimeSpan t2 = new TimeSpan(); // Duração 'vazia'
            TimeSpan t3 = new TimeSpan(900000000L); // Quantidade de 'ticks' de um intervalo de 1:30
            TimeSpan t4 = new TimeSpan(2, 11, 21); // Hora, minuto e segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21); // Dia, hora, minuto e segundo
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 300); // Dia, hora, minuto, segundo e milisegundo

            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine();
            Console.WriteLine("---------- INSTANCIAR UTILIZANDO FROM ----------");
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(100000L);

            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
        }
    }
}
