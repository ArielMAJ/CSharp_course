using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] listaQuartos = new Quarto[10];

            for (int i = 0; i < 10; i++)
                listaQuartos[i] = new Quarto(i+1);

            Console.Write("How many rooms will be rented? ");
            int nQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < nQuartos; i++)
            {
                Console.WriteLine($"\nRent {1+i}:");

                int numeroQuarto;
                while (true)
                {
                    Console.Write("Room: ");
                    numeroQuarto = int.Parse(Console.ReadLine());
                    if (listaQuartos[numeroQuarto-1].Ocupado)
                        Console.WriteLine("Room already rented, choose another one.");
                    else
                        break;
                }

                Console.Write("Name: ");
                listaQuartos[numeroQuarto-1].Name = Console.ReadLine();
                Console.Write("Email: ");
                listaQuartos[numeroQuarto-1].Email = Console.ReadLine();



            }


            Console.WriteLine("\nBusy Rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (listaQuartos[i].Ocupado)
                    Console.WriteLine(listaQuartos[i]);
            }

        }

    }
}