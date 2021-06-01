using Aula143CriandoExcecoesPersonalizadasParte1.Entities.Exceptions;
using System;
using System.Text;

namespace Aula143CriandoExcecoesPersonalizadasParte1.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Reservation: Room {RoomNumber}, ");
            str.Append($"check-in: {CheckIn.ToString("dd/MM/yyyy")}, ");
            str.Append($"check-out: {CheckOut.ToString("dd/MM/yyyy")}, ");
            str.AppendLine($"{Duration()} nights");

            return str.ToString();
        }
    }
}
