using System;
using Aula_143.Entities;

namespace Aula_143
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReservationManager reservationManager = new ReservationManager();

            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("Reservation Manager - Choose one option:\n\n1: Add reservations\n2: Summary\n3: Update Reservation\n0: Exit Program");
                choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        reservationManager.addReservations();
                        break;
                    case "2":
                        reservationManager.ReservationSummary();
                        break;
                    case "3":
                        reservationManager.UpdateReservation();
                        break;
                    case "0":
                        Console.WriteLine("Program ended.\n");
                        break;
                    default:
                        Console.WriteLine("Unknown selection.\n-------------\n");
                        break;
                }
            }
        }
    }

}