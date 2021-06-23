using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Dot() => Console.Write(".");
        static void NewLine() => Console.WriteLine();


        //WzorekB
        static void WzorekB(int n)
        {
            //Góra
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            //Środek
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Dot();
                Star();
                for (int j = 0; j < n - 2 - i; j++)
                    Dot();
                NewLine();
            }

            //Dół
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

        }


        //WzorekA
        static void WzorekA(int n, int m)
        {
            if (n < 3 || m < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n > 100 || m > 100) throw new ArgumentException("zbyt duży rozmiar");
            if (n % 2 == 0) n = n + 1;
            if (m % 2 == 0) m = m + 1;

            //Góra
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for (int i = 0; i < (m / 2) - 1; i++)
            {
                Star();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Dot();
                Star();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Dot();
                Star();
                NewLine();
            }

            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            for (int i = 0; i < (m / 2) - 1; i++)
            {
                Star();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Dot();
                Star();
                for (int j = 0; j < (n / 2) - 1; j++)
                    Dot();
                Star();
                NewLine();
            }

            //Dół
            for (int i = 0; i < n; i++)
                Star();
            NewLine();
        }

        static void Main(string[] args)
        {
            string wejscie = Console.ReadLine();
            string[] dane = wejscie.Split(" ");
            string typ = dane[0];
            int n = int.Parse(dane[1]);
            int m = 0;
            if (dane.Length == 3)
            {
                m = int.Parse(dane[2]);
            }
            if (typ == "A")
            {
                WzorekA(n, m);
            }
            if (typ == "B")
            {
                WzorekB(n);
            }
        }
    }
}