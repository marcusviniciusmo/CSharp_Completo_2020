using System;
using System.Globalization;

namespace Aula42ComecandoAResolverUmSegundoProblemaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida:
             * 
             * - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque);
             * - Realizar uma entrada no estoque e mostrar novamente os dados do produto;
             * - Realizar uma saída no estoque e mostrar novamente os dados do produto;
             * 
             * Para realizar este problema, você deve criar uma CLASSE conforme exemplo dado.
             */

            Produto produto1 = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {produto1}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());

            Console.WriteLine();
            produto1.AdicionarProdutos(quantidadeAdicionada);
            Console.WriteLine($"Dados atualizados: {produto1}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());

            Console.WriteLine();
            produto1.RemoverProdutos(quantidadeRemovida);
            Console.WriteLine($"Dados atualizados: {produto1}");
        }
    }
}
