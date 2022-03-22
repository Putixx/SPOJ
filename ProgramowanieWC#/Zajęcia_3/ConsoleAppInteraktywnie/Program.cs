using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void Dot() => Console.Write(".");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        //LiteraLustroZ
        static void LiteraLustroZ(int n)
        {
            if (n < 5) throw new ArgumentException("zbyt mały rozmiar");

            //Góra
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            //Środek
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Space();
                StarLn();
            }

            //Dół
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

        }

        //LiteraZ
        static void LiteraZ(int n)
        {
            if (n < 5) throw new ArgumentException("zbyt mały rozmiar");

            //Góra
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            //Środek
            for (int i = n - 2; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Space();
                StarLn();
            }

            //Dół
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

        }


        //Klepsydra
        static void Klepsydra(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            //Góra
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            //Górna część środka
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //Jeśli n jest nieparzysty
            if (n % 2 != 0)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Space();
                }
                StarLn();

            }

            //Dolna część środka
            for (int i = n / 2 - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //Dół
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

        }


        //LiteraX
        static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            //Góra
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //Jeśli n jest nieparzysty
            if (n % 2 != 0)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Space();
                }
                StarLn();

            }

            //Dół
            for (int i = n / 2; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 * i; j++)
                    Space();
                StarLn();
            }

        }


        //TrojkatP1
        static void TrojkatP1(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n - 1;


            //Góra
            for (int j = 0; j < n / 2; j++)
            {
                Space();
            }
            StarLn();

            //Środek
            for (int i = n / 2 - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //Dół
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

        }


        //TrojkatP2
        static void TrojkatP2(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n - 1;


            //Góra
            for (int i = 0; i < n - 1; i++)
                Star();
            StarLn();

            //Środek
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //Dół
            for (int j = 0; j < n / 2; j++)
            {
                Space();
            }
            StarLn();
        }



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

            //Prostokąt
            if (m != n)
            {
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

            //Kwadrat
            else
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Star();
                    NewLine();
                }

            }
        }


        static void Main(string[] args)
        {
            WzorekA(9, 6);
            Console.WriteLine("------------");
            WzorekA(3, 3);
            Console.WriteLine("------------");
            TrojkatP2(7);
            Console.WriteLine("------------");
            TrojkatP2(8);
            Console.WriteLine("------------");
            TrojkatP2(3);


            //string wejscie = Console.ReadLine();
            //string[] dane = wejscie.Split(" ");
            //string typ = dane[0];
            //int n = int.Parse(dane[1]);
            //int m = 0;
            //if (dane.Length == 3)
            //{
            //    m = int.Parse(dane[2]);
            //}
            //if (typ == "A")
            //{
            //    WzorekA(n, m);
            //}
            //if (typ == "B")
            //{
            //    WzorekB(n);
            //}
        }
    }
}