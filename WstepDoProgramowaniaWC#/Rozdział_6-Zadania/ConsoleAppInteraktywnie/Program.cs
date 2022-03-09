using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int a = 0; a < tablica2d.GetLength(0); a++)
            {
                for (int b = 0; b < tablica2d.GetLength(1); b++)
                {
                    Console.Write("{0, 3}", tablica2d[a, b]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}