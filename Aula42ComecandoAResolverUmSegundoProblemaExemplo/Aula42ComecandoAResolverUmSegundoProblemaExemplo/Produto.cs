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
    }
}
