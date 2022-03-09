using System;

namespace Program
{
    class Program
    {
        //ZADANIE 4
        public static double Srednia(int[,] tab)
        {
            int suma = 0, licznik = 0;
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i,j] > 0)
                    {
                        suma += tab[i, j];
                        licznik++;
                    }
                }
            }
            double srednia = (double)suma / licznik;

            return Math.Round(srednia, 2);
        }



        //ZADANIE 2
        /// <summary>
        /// Oblicza pole trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
        /// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
        /// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>pole trójkąta obliczone z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
        public static double TriangleArea(int a, int b, int c, int precision = 2)
        {
            if(a < 0 || b < 0 || c < 0 || precision < 2 || precision > 8) throw new ArgumentOutOfRangeException("wrong arguments");
            if(a+b < c || a+c < b || b+c < a) throw new ArgumentException("object not exist");

            double p = ((double)a+b+c)/2;
            double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return Math.Round(pole, precision);
        }



        //ZADANIE 1
        static void Wzorek(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n - 1;


            //Góra
            for (int i = 0; i < n - 1; i++)
                Console.Write('*');
            Console.WriteLine('*');

            //Środek
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write(" ");
                Console.Write('*');
                for (int j = 0; j < n - 2 - 2 - 2 * i; j++)
                    Console.Write('*');
                Console.WriteLine('*');
            }

            //Dół
            for (int j = 0; j < n / 2; j++)
                Console.Write(" ");
            Console.WriteLine('*');
        }

        static void Main(string[] args)
        {
            //ZADANIE 1
            Wzorek(7);
            Wzorek(8);
            Wzorek(3);



            //ZADANIE 2
            Console.WriteLine(TriangleArea(1, 1, 1, 3));
            Console.WriteLine(TriangleArea(2, 3, 4, 3));
            Console.WriteLine(TriangleArea(2, 2, 2, 3));
            Console.WriteLine(TriangleArea(5, 5, 5, 3));
            try { TriangleArea(-1, 0, 1, 9); }
            catch { Console.WriteLine("wrong arguments"); }

            try { TriangleArea(1, 2, 10, 8); }
            catch { Console.WriteLine("object not exist"); }



            //ZADANIE 3
            int x, y, z;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());

                Console.WriteLine(x+y+z);
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
            int[,] tab = new int[6, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] tab1 = new int[3, 1] { { 1 }, { 2 }, { 3 } };
            int[,] tab2 = new int[1, 3] { { -1, 1, 1 } };
            int[,] tab3 = new int[2, 2] { { 1, 1 }, { 2, -1 } };

            Console.WriteLine(Srednia(tab));
            Console.WriteLine(Srednia(tab1));
            Console.WriteLine(Srednia(tab2));
            Console.WriteLine(Srednia(tab3));
        }
    }
}
