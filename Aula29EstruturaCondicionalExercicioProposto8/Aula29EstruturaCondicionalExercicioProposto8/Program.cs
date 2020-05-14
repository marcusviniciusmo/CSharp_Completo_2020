using System;
using System.Globalization;

namespace Aula29EstruturaCondicionalExercicioProposto8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Em um país imaginário chamado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existe políticos
             * corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo o
             * símbolo é o R$.
             * 
             * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa
             * deve pagar de Imposto de Renda, segundo a tabela abaixo.
             *  __________________________________________________
             * |        Renda                  |  Imposto de Renda |
             * |de 0.0 a R$ 2000.00            |      Isento       |
             * |de R$ 2000.01 até R$ 3000.00   |        8%         |
             * |de R$ 3000.01 até R$ 4500.00   |       18%         |
             * |acima de R$ 4500.00            |       28%         |
             *  ---------------------------------------------------
             *  
             *  Lembre-se que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de 
             *  R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00,
             *  o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
             */

            Console.WriteLine("Insira o valor do trabalhador de Lisarb:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
;
            double rendaDeduzida = 0.00, imposto = 0.00;

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                rendaDeduzida = salario - 2000.00;
                imposto = rendaDeduzida * 0.08;
                Console.WriteLine($"R$ {imposto}");
            }
            else if (salario <= 4500.00)
            {
                rendaDeduzida = salario - 2000.00;
                imposto = (1000.00 * 0.08) + ((rendaDeduzida - 1000.00) * 0.18);
                Console.WriteLine($"R$ {imposto}");
            }
            else
            {
                rendaDeduzida = salario - 2000.00;
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((rendaDeduzida - 1000.00 - 1500.00) * 0.28);
                Console.WriteLine($"R$ {imposto}");
            }
        }
    }
}
