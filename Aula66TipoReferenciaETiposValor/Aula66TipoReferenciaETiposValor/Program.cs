using System;

namespace Aula66TipoReferenciaETiposValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; // Não é necessário instanciar da seguinte forma: Point p = new Point();

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            // Porém, o struct aceita o comando new

            p = new Point();

            Console.WriteLine(p); // Instancia um novo valor pra p.
        }
    }
}
