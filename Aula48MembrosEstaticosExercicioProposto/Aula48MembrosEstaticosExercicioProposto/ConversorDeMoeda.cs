namespace Aula48MembrosEstaticosExercicioProposto
{
    class ConversorDeMoeda
    {
        static double IOF = 0.06; // 6% sobre o valor

        public static double ConverterMoeda(double cotacao, double quantidade)
        {
            return (cotacao * quantidade) + IOF * cotacao * quantidade ;
        }
    }
}
