using System;

namespace Aula33EstruturaRepetitivaEnquantoExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem 
             * "Senha Inválida". Quando a senha for informada corretamente, deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que 
             * a senha correta é o valor 2002.
             */

            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            int senhaCorreta = 2002;

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Inválida");

                Console.WriteLine("");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
