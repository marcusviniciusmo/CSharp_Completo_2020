using Aula207GetHashCodeEEqualsExercicio.Entities;
using System;

namespace Aula207GetHashCodeEEqualsExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client c2 = new Client() { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine("Equals:");
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1 == c2); // Compara a referência do ponteiro do endereço de memória do objeto.

            Console.WriteLine();

            Console.WriteLine("GetHashCode:");
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}
