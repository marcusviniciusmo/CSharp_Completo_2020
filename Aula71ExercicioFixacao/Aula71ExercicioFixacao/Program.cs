using System;

namespace Aula71ExercicioFixacao
{
    class Program
    {
        /* A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos número de 0 a 9.
         * 
         * Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
         * 
         * Fazer um programa que inicie todos os dez quartos vazios, e depois leia uma quantidade N representando o número de estudantes que vão alugar quartos 
         * (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e o e-mail do estudante, 
         * bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas
         * as ocupações do pensionato, por ordem de quarto, conforme exemplo.
         */
        static void Main(string[] args)
        {
            int totalQuartosPensionato = 10;
            int[] totalQuartos = new int[totalQuartosPensionato];

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine()); // Número de estudantes que vão alugar quartos

            Estudante[] estudante = new Estudante[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nomeEstudante = Console.ReadLine();
                Console.Write("Email: ");
                string emailEstudante = Console.ReadLine();
                Console.Write("Quarto: ");
                int quartoAlugadoEstudante = int.Parse(Console.ReadLine());

                estudante[i] = new Estudante { Nome = nomeEstudante, Email = emailEstudante, QuartoAlugado = quartoAlugadoEstudante};
                totalQuartos[quartoAlugadoEstudante] = quartoAlugadoEstudante;
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < totalQuartosPensionato; i++)
            {
                if (totalQuartos[i] != 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if(estudante[j].QuartoAlugado == totalQuartos[i])
                        {
                            Console.WriteLine($"{estudante[j].QuartoAlugado}: {estudante[j].Nome}, {estudante[j].Email}");
                        }
                    }
                }
            }
        }
    }
}
