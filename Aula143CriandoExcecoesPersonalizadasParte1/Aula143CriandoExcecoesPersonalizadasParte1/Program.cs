using System;
using Aula143CriandoExcecoesPersonalizadasParte1.Entities;
using Aula143CriandoExcecoesPersonalizadasParte1.Entities.Exceptions;

namespace Aula143CriandoExcecoesPersonalizadasParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data de entrada e data de saída)
             * e mostrar os dados da reserva, inclusive sua duração em dias. Em seguida, ler novas datas de entrada e saída,
             * atualizar a reserva, e mostrar novamente a reserva com os dados atualizados. O programa não deve aceitar dados 
             * inválidos para a reserva, conforme as seguintes regras:
             * 
             * Alterações de reserva só podem ocorrer para datas futuras.
             * A data de saída deve ser maior que a data de entrada.
             */

            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
