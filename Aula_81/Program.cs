using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o formato da matriz (ex.: \"3,4\"): ");
            string[] rc = Console.ReadLine().Split(',');
            int r = int.Parse(rc[0]), c = int.Parse(rc[1]);
            int[,] mat = new int[r, c];

            Console.WriteLine("\nDigite cada linha da matriz (ex.: \"2,3,1\"):");
            for (int row = 0; row < r; row++)
            {
                string[] current_row = Console.ReadLine().Split(',');
                for (int col = 0; col < c; col++)
                {
                    mat[row, col] = int.Parse(current_row[col]);
                }
            }

            Console.Write("\nDigite o número a ser procurado: ");
            int num = int.Parse(Console.ReadLine());

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    if (mat[row, col] == num)
                    {
                        Console.WriteLine($"\nPosition {row},{col}:");
                        if (col > 0)
                            Console.WriteLine($"Left: {mat[row, col - 1]}");
                        if (col < c-1)
                            Console.WriteLine($"Right: {mat[row, col + 1]}");
                        if (row > 0)
                            Console.WriteLine($"Up: {mat[row - 1, col]}");
                        if (row < r-1)
                            Console.WriteLine($"Down: {mat[row + 1, col]}");
                    }

                }
            }

        }
    }
}
