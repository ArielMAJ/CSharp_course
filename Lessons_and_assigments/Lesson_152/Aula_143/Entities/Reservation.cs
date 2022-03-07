using System;
using System.Text;
using Aula_143.Entities.Exceptions;
namespace Aula_143.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (
                (DateTime.Compare(checkIn, checkOut) >= 0)
                ||
                (DateTime.Compare(DateTime.Today, checkIn) >= 0)
            )
            {
                throw new DomainException("Invalid dates. CheckIn has to be before checkOut, both in future dates.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            return (CheckOut - CheckIn).Days;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (
                (DateTime.Compare(checkIn, checkOut) >= 0)
                ||
                (DateTime.Compare(DateTime.Today, checkIn) >= 0)
            )
            {
                throw new DomainException("Invalid dates. CheckIn has to be before checkOut, both in future dates.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Room number: ");
            sb.Append(RoomNumber);
            sb.Append("\nCheckIn: ");
            sb.Append(CheckIn.ToString("dd/MM/yyyy"));
            sb.Append(" CheckOut: ");
            sb.Append(CheckOut.ToString("dd/MM/yyyy"));
            sb.Append("\nDuration: ");
            sb.Append(Duration());
            sb.Append(" nights.");

            return sb.ToString();
        }
    }
}
