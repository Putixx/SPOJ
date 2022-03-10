using System;

namespace ConsoleAppInteraktywnie
{
    /* Zadanie 6.1 / Zadanie 6.2 */
    public class Prostokat
    {
        public Prostokat(double Dlugosc, double Szerokosc)
        {
            this.Dlugosc = Dlugosc;
            this.Szerokosc = Szerokosc;
        }

        private double Dlugosc { get; set; }
        private double Szerokosc { get; set; }

        private double Powierzchnia(double Dlugosc, double Szerokosc)
        {
            return Dlugosc * Szerokosc;
        }

        private double Obwod(double Dlugosc, double Szerokosc)
        {
            return 2 * Dlugosc + 2 * Szerokosc;
        }

        public double[] Prezentuj()
        {
            return new double[] { Powierzchnia(Dlugosc, Szerokosc), Obwod(Dlugosc, Szerokosc) };
        }
    }

    /* Zadanie 6.4 */
    public class LicznikPradu
    {
        public LicznikPradu(double LicznikPoczatkowa, double LicznikObecna)
        {
            this.LicznikPoczatkowa = LicznikPoczatkowa;
            this.LicznikObecna = LicznikObecna;
        }

        private double LicznikPoczatkowa { get; set; }
        private double LicznikObecna { get; set; }

        public void WyswietlAktualnyStanLicznika()
        {
            Console.WriteLine("Aktualny stan licznika: " + LicznikObecna);
        }

        public void WyswietlPierwotnyStanLicznika()
        {
            Console.WriteLine("Początkowy stan licznika: " + LicznikPoczatkowa);
        }

        public void WyswietlLaczneZuzycie()
        {
            Console.WriteLine("Zużycie energii: " + (LicznikObecna - LicznikPoczatkowa));
        }
    }

    /* Zadanie 6.5 */

    public class Punkt
    {
        public Punkt(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public void Przesun(double X, double Y)
        {
            this.X = this.X + X;
            this.Y = this.Y + Y;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Współrzędne punktu: ( " + X + ", " + Y + " )");
        }

    }


    /* Zadanie 6.7 */
    public class Odcinek
    {
        public Odcinek(Punkt P1, Punkt P2)
        {
            this.P1 = P1;
            this.P2 = P2;
        }

        public Punkt P1 { get; set; }
        public Punkt P2 { get; set; }

        public double DlugoscOdcinka()
        {
            return Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
        }
    }

    /* Zadanie 6.10 */
    public struct KandydatNaStudia
    {
        public KandydatNaStudia(string Nazwisko, int PunktyMatematyka, int PunktyInformatyka, int PunktyJezykObcy)
        {
            this.Nazwisko = Nazwisko;
            this.PunktyMatematyka = PunktyMatematyka;
            this.PunktyInformatyka = PunktyInformatyka;
            this.PunktyJezykObcy = PunktyJezykObcy;
        }

        public string Nazwisko { get; set; }
        public int PunktyMatematyka { get; set; }
        public int PunktyInformatyka { get; set; }
        public int PunktyJezykObcy { get; set; }


        public double ObliczPunkty()
        {
            return PunktyMatematyka * 0.6 + PunktyInformatyka * 0.5 + PunktyJezykObcy * 0.2;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Kandydat " + Nazwisko + " liczba punktów: " + ObliczPunkty()) ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Zadanie 6.1 */
            Console.WriteLine("-----------------------------------------------------------");
            Prostokat pr1 = new Prostokat(2,5);
            Console.WriteLine("Powierzchnia: " + pr1.Prezentuj()[0] + " Obwód: " + pr1.Prezentuj()[1]);

            /* Zadanie 6.2 */
            Console.WriteLine("-----------------------------------------------------------");
            Prostokat[] prostokaty = new Prostokat[]
                {
                    new Prostokat(2,20),
                    new Prostokat(3,5),
                    new Prostokat(3,7),
                    new Prostokat(3,9)
                };

            foreach (Prostokat pr in prostokaty)
                Console.WriteLine("Powierzchnia: " + pr.Prezentuj()[0] + " Obwód: " + pr.Prezentuj()[1]);

            /* Zadanie 6.3 */
            Console.WriteLine("-----------------------------------------------------------");
            double max = 0;

            foreach (Prostokat pr in prostokaty)
            {
                if(max < pr.Prezentuj()[0])
                   max = pr.Prezentuj()[0];

                Console.WriteLine("Powierzchnia: " + pr.Prezentuj()[0] + " Obwód: " + pr.Prezentuj()[1]);
            }
            Console.WriteLine("Największy prostokąt ma powierzchnię: " + max);

            /* Zadanie 6.4 */
            Console.WriteLine("-----------------------------------------------------------");

            LicznikPradu lp = new LicznikPradu(12, 25);
            lp.WyswietlPierwotnyStanLicznika();
            lp.WyswietlAktualnyStanLicznika();
            lp.WyswietlLaczneZuzycie();

            /* Zadanie 6.5 */
            Console.WriteLine("-----------------------------------------------------------");

            Punkt p1 = new Punkt(2, 5);
            p1.Wyswietl();
            p1.Przesun(3, -2);
            p1.Wyswietl();


            /* Zadanie 6.7 */
            Console.WriteLine("-----------------------------------------------------------");

            Punkt p11 = new Punkt(1, 1);
            Punkt p12 = new Punkt(1, 3);

            Odcinek odc = new Odcinek(p11, p12);
            Console.WriteLine("Długość odcinka wynosi: " + odc.DlugoscOdcinka());

            /* Zadanie 6.10 */
            Console.WriteLine("-----------------------------------------------------------");
            KandydatNaStudia[] kandydaci = new KandydatNaStudia[]
                {
                    new KandydatNaStudia("Kowal", 80, 80, 100),
                    new KandydatNaStudia("Pstr", 87, 82, 100),
                    new KandydatNaStudia("Dzi", 80, 40, 20),
                    new KandydatNaStudia("Nowak", 80, 10, 100)
                };

            foreach (KandydatNaStudia k in kandydaci)
                k.WyswietlDane();


        }
    }
}