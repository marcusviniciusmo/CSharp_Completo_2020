namespace Aula73ModificadorParametroRef
{
    class Calculator
    {
        public static void FuncaoQueNaoTriplica(int x)
        {
            x = x * 3;
        }

        public static void FuncaoQueTriplica(ref int x)
        {
            x = x * 3;
        }
    }
}
