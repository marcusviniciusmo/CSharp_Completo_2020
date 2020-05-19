namespace Aula45ClassesAtributosMetodosExercicioFixacao3
{
    class Aluno
    {
        public string Nome;
        public double nota1, nota2, nota3;

        public double CalcularNotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if (CalcularNotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalcularPontosRestantes()
        {
            return 60.00 - CalcularNotaFinal();
        }
    }
}
