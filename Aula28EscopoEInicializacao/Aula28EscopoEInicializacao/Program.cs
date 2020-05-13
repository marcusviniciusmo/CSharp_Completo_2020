using System;

namespace Aula28EscopoEInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            double desconto = 0.0; // A variável 'desconto' deve ser declarada e inicializada antes do escopo do if. A variável deve ser inicializada pois,
            // caso a condição seja falsa, não será atribuído valor à variável, sendo assim, não é possível manipulá-la.

            if (preco > 100.0)
            {
                // double desconto = preco * 0.1;       => Se a variável 'desconto' for declarada dentro do escopo do if, ela só servirá durante a execução desse escopo,
                // não sendo possível sua utilização depois desse escopo.
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
