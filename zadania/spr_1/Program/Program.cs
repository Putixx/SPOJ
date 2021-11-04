using System;

namespace Program
{
    class Program
    {
        //ZADANIE 4
        public static double Srednia(int[][] tab)
        {
            int suma = 0, licznik = 0;
            double srednia = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab[i].Length; j++)
                {
                    if (tab[i][j] > 0)
                    {
                        suma += tab[i][j];
                        licznik++;
                    }
                }
            }
            if (licznik == 0)
                licznik += 1;
            srednia = (double)suma / licznik;

            return Math.Round(srednia, 2);
        }



        //ZADANIE 2
        /// <summary>
        /// Oblicza pole trapezu równoramiennego dla zadanych długości: obu podstaw oraz ramienia, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="base1">długość pierwszej podstawy, liczba całkowita nieujemna</param>
        /// <param name="base2">długość drugiej podstawy, liczba całkowita nieujemna</param>
        /// <param name="leg">długość ramienia, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>pole trapezu obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trapezu nie można utworzyć</exception>
        public static double TrapesoidIsoscelesArea(int base1, int base2, int leg, int precision = 2)
        {
            if(base1 < 0 || base2 < 0 || leg < 0 || precision < 2 || precision > 8) throw new ArgumentOutOfRangeException("wrong arguments");
            if(Math.Abs(base1*base1 - base2*base2) < Math.Abs(leg*leg-leg*leg) || base1 > leg+base2 || base2 > leg+base1) throw new ArgumentException("object not exist");

            double p = Math.Abs((base1-base2)/2.0);
            double h = Math.Sqrt(((double)leg*leg)-(p*p));
            Console.WriteLine("wysokosc "+h);
            double pole = ((base1 + base2) * h) / 2;

            return Math.Round(pole, precision);
        }



        //ZADANIE 1
        static void Wzorek(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            //Góra
            for (int i = 0; i < n - 1; i++)
                Console.Write('*');
            Console.WriteLine('*');

            //Środek
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                    Console.Write(" ");
                Console.WriteLine('*');
            }
        }
        

        static void Main(string[] args)
        {
            //ZADANIE 1
            Wzorek(7);
            Wzorek(8);
            Wzorek(3);



            //ZADANIE 2
            //Console.WriteLine(TrapesoidIsoscelesArea(1, 1, 1, 3));
            //Console.WriteLine(TrapesoidIsoscelesArea(1, 2, 10, 3));
            //try { TrapesoidIsoscelesArea(-1, 0, 1, 9); }
            //catch (ArgumentOutOfRangeException) { Console.WriteLine("wrong arguments"); }

            //try { Console.WriteLine(TrapesoidIsoscelesArea(4, 1, 1, 2)); }
            //catch (ArgumentException) { Console.WriteLine("object not exist"); }



            //ZADANIE 3
            int x, y, z;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());

                if(x + y > 0 && x + z > 0 && z + y > 0)
                {
                    if (x + y == z || x + z == y || z + y == x)
                        Console.WriteLine("yes");
                    else
                        Console.WriteLine("no");
                }
                else
                    Console.WriteLine("overflow exception, exit");
                
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception, exit");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argument exception, exit");
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
            }
            catch
            {
                Console.WriteLine("non supported exception, exit");
            }



            //ZADANIE 4
            int[][] tab = new int[][] {
            new int[4] { 1, 1, 1, 1 },
            new int[2] { 2, 2 },
            new int[6] { 3, 3, 3, 3, 3, 3 }
            };
            int[][] tab1 = new int[][] {
            new int[3] { 1, 2, 3 }
            };
            int[][] tab2 = new int[][] {
            new int[1] { -1 },
            new int[1] { 1 },
            new int[1] { 1 }
            };
            int[][] tab3 = new int[][] {
            new int[2] { 1, 1 },
            new int[2] { 2, -1 }
            };
            int[][] tab4 = new int[][] {
            new int[2] { -1, -2 },
            new int[2] { -3, -4 }
            };

            Console.WriteLine(Srednia(tab));
            Console.WriteLine(Srednia(tab1));
            Console.WriteLine(Srednia(tab2));
            Console.WriteLine(Srednia(tab3));
            Console.WriteLine(Srednia(tab4));
        }
    }
}
