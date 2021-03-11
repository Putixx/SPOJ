using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj "+imie+" "+nazwisko+"!");

            string napis = string.Format("Witaj {0} {1}!", imie, nazwisko);
            Console.WriteLine(napis);

            Console.WriteLine("Witaj {0} {1}!", nazwisko, imie);

            Console.WriteLine($"Witaj {imie} {nazwisko}!");

        }
    }
}
