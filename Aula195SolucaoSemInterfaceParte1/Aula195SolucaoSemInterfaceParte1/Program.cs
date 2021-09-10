using Aula195SolucaoSemInterfaceParte1.Entities;
using System;
using System.Globalization;

namespace Aula195SolucaoSemInterfaceParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas.
             * Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um valor diário.
             * Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que,
             * no caso do Brasil, é 20% para valores até 100.00, ou 15% para valores acima de 100.00.
             * Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação),
             * bem como o valor por hora e o valor diário de locação. O programa deve então gerar a nota de pagamento
             * (contendo valor da locação, valor do imposto e valor total do pagamento) e informar os dados na tela.
             */

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}
