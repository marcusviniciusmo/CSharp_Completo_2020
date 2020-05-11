using System;
using System.Globalization;

namespace Aula18SaidaDeDadosExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Em um novo programa, inicie as seguintes variáveis:
             * 
             * string produto1 = "Computador";
             * string produto2 = "Mesa de escritório";
             * 
             * byte idade = 30;
             * int codigo = 5290;
             * char genero = 'M';
             * 
             * double preco1 = 2100.0;
             * double preco2 = 650.50;
             * double medida = 53.234567;
             * 
             * Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:
             * 
             * Produtos:
             * Computador, cujo preço é $ 2100,00
             * Mesa de escritório, cujo preço é $ 650,00
             * 
             * Registro: 30 anos de idade, código 5290 e gênero: M
             * 
             * Medidas com oito casas decimais: 53,23456700
             * Arredondado (três casas decimais): 53,235
             * Separador decimal invariant culture: 53.235
             */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            double preco1 = 2100.0;
            double preco2 = 650.50;
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
