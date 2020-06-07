using System;
using System.Globalization;

namespace Aula51Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            // Produto prod = new Produto(nome, preco, quantidade); --- Construtor de 3 argumentos.
            Produto prod = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {prod}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(quantidadeAdicionada);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {prod}");

            Console.WriteLine();
            Console.Write($"Digite o número de produtos a ser removido do estoque: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(quantidadeRemovida);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados {prod}");
        }
    }
}
