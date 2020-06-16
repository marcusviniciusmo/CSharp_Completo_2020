using System;
using System.Globalization;

namespace Aula55EncapsulamentoImplementacaoManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto1.GetNome());

            produto1.SetNome("TV 4K");

            Console.WriteLine(produto1.GetNome());
            Console.WriteLine(produto1.GetPreco().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
