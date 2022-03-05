using System;
using System.Collections.Generic;
using System.Globalization;
using Aula_143.Entities.Exceptions;

namespace Aula_143.Entities
{
    internal class ReservationManager
    {
        public List<Reservation> reservations = new List<Reservation>();


        public void addReservations()
        {
            int amount = -1;
            while (amount == -1)
            {
                try
                {
                    Console.Write("Enter the number of reservations to add: ");
                    amount = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex) { Console.WriteLine("Please only write numbers.\n"); }
            }
            int i_th = 1;
            while (i_th <= amount)
            {
                Console.WriteLine($"\nReservation #{i_th} data:");
                try
                {
                    Console.Write("Room number: ");
                    int room = int.Parse(Console.ReadLine());

                    Console.Write("CheckIn (DD/MM/YYYY): ");
                    DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    Console.Write("CheckOut (DD/MM/YYYY): ");
                    DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    reservations.Add(new Reservation(room, checkIn, checkOut));
                    i_th++;
                    Console.Clear();
                }
                //catch (ArgumentNullException ex) { Console.WriteLine("ArgumentNullException:\n" + ex.Message); }
                //catch (InvalidDataException ex) { Console.WriteLine("InvalidDataException:\n" + ex.Message); }
                catch (FormatException ex) { Console.WriteLine("Please, write the correct type of data."); }
                catch (DomainException ex) { Console.WriteLine("DomainException:\n" + ex.Message); }
                catch (Exception ex) { Console.WriteLine("Exception:\n" + ex.Message); }
            }
        }

        public void ReservationSummary()
        {
            Console.WriteLine("\nRESERVATIONS SUMMARY:\n");
            foreach (Reservation reservation in reservations.OrderBy(x => x.RoomNumber))
            {
                Console.WriteLine(reservation + "\n------------------");
            }
            Console.WriteLine("");
        }

        public void UpdateReservation()
        {
            Console.Write("Which room do you wish to update the reservation for? ");
            int room = int.Parse(Console.ReadLine());
            int index = reservations.FindIndex(x => x.RoomNumber == room);

            if (index != -1)
            {
                try
                {
                    Console.Write("New CheckIn (DD/MM/YYYY): ");
                    DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    Console.Write("New CheckOut (DD/MM/YYYY): ");
                    DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    reservations[index].UpdateDates(checkIn, checkOut);
                }
                catch (ArgumentNullException ex) { Console.WriteLine("ArgumentNullException:\n" + ex.Message); }
                //catch (InvalidDataException ex) { Console.WriteLine("InvalidDataException:\n" + ex.Message); }
                catch (FormatException ex) { Console.WriteLine("FormatException:\n" + ex.Message); }
                catch (DomainException ex) { Console.WriteLine("DomainException:\n" + ex.Message); }
                catch (Exception ex) { Console.WriteLine("Exception:\n" + ex.Message); }
            }
            else
            {
                Console.WriteLine("Room not found.\n-------------\n");
            }
        }


    }

}
