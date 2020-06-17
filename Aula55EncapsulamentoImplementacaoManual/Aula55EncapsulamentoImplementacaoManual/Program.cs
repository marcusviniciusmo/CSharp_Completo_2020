using System;
using System.Globalization;

namespace Aula55EncapsulamentoImplementacaoManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto1.Nome);

            produto1.Nome = "TV 4K";

            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
