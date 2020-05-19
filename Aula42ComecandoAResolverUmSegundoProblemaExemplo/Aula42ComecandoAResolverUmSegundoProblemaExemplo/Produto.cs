using System.Globalization;

namespace Aula42ComecandoAResolverUmSegundoProblemaExemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidadeAdicionada)
        {
            Quantidade += quantidadeAdicionada;
        }

        public void RemoverProdutos(int quantidadeRemovida)
        {
            Quantidade -= quantidadeRemovida;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ " +
                $"{ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
