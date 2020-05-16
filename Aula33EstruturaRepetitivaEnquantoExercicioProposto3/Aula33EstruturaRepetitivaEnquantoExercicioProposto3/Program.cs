using System;

namespace Aula33EstruturaRepetitivaEnquantoExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível
             * abastecido (codificado da seguinte forma: 1. Álcool, 2. Gasolina, 3. Diesel, 4. Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4)
             * deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem:
             * "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
             */

            int opcao = 0, contadorAlcool = 0, contadorGasolina = 0, contadorDiesel = 0;

            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");

            while (opcao != 4)
            {
                Console.WriteLine("");
                Console.Write("Escolha um produto: ");
                opcao = int.Parse(Console.ReadLine());

                if ((opcao > 4) || (opcao < 1))
                    Console.WriteLine("Opção inválida");
                else if (opcao == 1)
                {
                    Console.WriteLine("Produto registrado com sucesso.");
                    contadorAlcool++;
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Produto registrado com sucesso.");
                    contadorGasolina++;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Produto registrado com sucesso.");
                    contadorDiesel++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {contadorAlcool}");
            Console.WriteLine($"Gasolina: {contadorGasolina}");
            Console.WriteLine($"Diesel: {contadorDiesel}");
        }
    }
}
