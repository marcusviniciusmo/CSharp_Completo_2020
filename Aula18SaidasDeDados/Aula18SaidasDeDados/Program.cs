using System;
using System.Globalization;

namespace Aula18SaidasDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            // IMPRIMINDO VARIÁVEIS
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("--------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine("--------------------------");
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine("--------------------------");
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // PLACEHOLDER
            Console.WriteLine("-------------------------- PLACEHOLDER");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo.ToString("F2",CultureInfo.InvariantCulture));

            // INTERPOLAÇÃO
            Console.WriteLine("-------------------------- INTERPOLAÇÃO");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");

            // CONCATENAÇÃO
            Console.WriteLine("-------------------------- CONCATENAÇÃO");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}
