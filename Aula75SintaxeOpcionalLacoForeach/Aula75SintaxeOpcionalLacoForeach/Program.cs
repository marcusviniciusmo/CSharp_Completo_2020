using System;

namespace Aula75SintaxeOpcionalLacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            foreach(string nome in vetor)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
