using System;

namespace Aula29EstruturaCondicionalExercicioProposto4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro,
             * tendo uma duração mínima de 1 hora e máxima de 24 horas.
             */

            Console.WriteLine("Insira a hora inicial do jogo:");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final do jogo:");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;

            if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
            }
            else if (horaFinal < horaInicial)
            {
                duracao = (24 - horaInicial) + horaFinal;
            }
            else
            {
                duracao = 24;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
