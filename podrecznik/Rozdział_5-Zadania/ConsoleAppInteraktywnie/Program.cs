using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        //Zadanie 5.1
        //static double temperatura(double fh)
        //{
        //    return (fh - 32) * 5 / 9;
        //}



        //Zadanie 5.2
        //static string nalezy(float a, float b, float x)
        //{
        //    string y;
        //        return y = (a < x && b > x) ? "True" : "False";
        //}



        //Zadanie 5.3
        //static void Przesun(ref float x, ref float y)
        //{
        //    x += 3;
        //    y += 2;
        //}



        //Zadanie 5.4
        //static int[] Pomnoz(int[] tab, int mnoznik)
        //{
        //    for (int i = 0; i < tab.Length; i++)
        //        tab[i] = tab[i] * mnoznik;

        //    return tab;
        //}



        //Zadanie 5.5
        //static void Rysuj(int a, int b, char znak)
        //{
        //    Console.WriteLine();
        //    for (int i = 0; i < b; i++)
        //    {
        //        for(int j = 0; j < a; j++)
        //            Console.Write(znak);
        //        Console.WriteLine();
        //    }
        //}



        //Zadanie 5.6
        //static string[] Pomnoz(string[] tab, int mnoznik)
        //{
        //    string[] newtab = new string[tab.Length];

        //    for (int i = 0; i < newtab.Length; i++)
        //        newtab[i] = tab[i];

        //    for (int i = 0; i < tab.Length; i++)
        //    {
        //        if (mnoznik > 1)
        //            for (int j = 1; j < mnoznik; j++)
        //                tab[i] += newtab[i];
        //        else
        //        {
        //            tab[i] = newtab[i];
        //        }
        //    }
        //    return tab;
        //}



        //Zadanie 5.7
        //static void Wyrazenie(float x, float n)
        //{
        //    float w = 0;

        //    for(int i = 1; i <= n; i++)
        //        w += x + i;

        //    Console.WriteLine("Wartość wyrażenia \"w\" wynosi: " + w);
        //}



        //Zadanie 5.8
        //static void SumaCyfr(char[] tab)
        //{
        //    int suma = 0;

        //    for (int i = 0; i < tab.Length; i++)
        //        suma += tab[i] - 48;

        //    Console.WriteLine("Suma cyfr podanej liczby: " + suma);
        //}



        //Zadanie 5.9 metoda rekurencyjna
        //static int Fibo(int n)
        //{
        //    if (n <= 1)
        //        return n;
        //    else
        //        return Fibo(n - 1) + Fibo(n - 2);
        //}

        //Zadanie 5.9 metoda iteracyjna
        //static int Fibo(int n)
        //{
        //    int a = 0, b = 1;

        //    for(int i = 0; i < n; i++)
        //    {
        //        b += a;
        //        a = b - a;
        //    }
        //    return a;
        //}
        


        //Zadanie 5.10
        //static int Oblicz(int n)
        //{
        //    if (n <= 1) return (1);
        //    else return (n + Oblicz(n - 1));
        //}



        static void Main(string[] args)
        {
            //Rozdział 5.10
            //Zadanie 5.1
            //Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
            //Console.WriteLine("Temperatura w Celsjuszach: " + temperatura(double.Parse(Console.ReadLine())));



            //Zadanie 5.2
            //Console.Write("Podaj trzy liczby rzeczywiste \"a b x\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(" ");
            //float a = float.Parse(tab[0]);
            //float b = float.Parse(tab[1]);
            //float x = float.Parse(tab[2]);

            //Console.WriteLine("Liczba \"x\" należy do przedziału (a, b): " + nalezy(a, b, x));



            //Zadanie 5.3
            //Console.Write("Podaj współrzędne punktu A \"x y\" : ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(" ");
            //float x = float.Parse(tab[0]);
            //float y = float.Parse(tab[1]);
            //Przesun(ref x, ref y);

            //Console.WriteLine("Przesunięcie o wektor [3,2] : " + "A = (" + x + ", " + y + ")");



            //Zadanie 5.4
            //Console.Write("Podaj ilość elementów: ");
            //int[] tab = new int[int.Parse(Console.ReadLine())];
            //Random roll = new Random();

            //for (int i = 0; i < tab.Length; i++)
            //    tab[i] = roll.Next(1, 10);

            //Console.WriteLine("Wylosowane wartości tablicy: ");
            //for (int i = 0; i < tab.Length; i++)
            //    Console.Write(tab[i] + ", ");

            //Console.Write("\nPodaj mnożnik: ");
            //int mnoznik = int.Parse(Console.ReadLine());

            //Pomnoz(tab, mnoznik);

            //Console.WriteLine("Wylosowane wartości tablicy po pomnożeniu: ");
            //for (int i = 0; i < tab.Length; i++)
            //    Console.Write(tab[i] + ", ");



            //Zadanie 5.5
            //Console.Write("Podaj długość: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Podaj szerokość: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Podaj znak: ");
            //string napis = Console.ReadLine();
            //char znak = napis[0];

            //Rysuj(a, b, znak);
            //Rysuj(b, a, znak);



            //Zadanie 5.6
            //string[] tab = { "ala", "ma", "kota" };
            //int mnoznik = 3;

            //Console.Write("Tablica: ");

            //for(int i = 0; i < tab.Length; i++)
            //    Console.Write(tab[i] + " ");

            //Pomnoz(tab, mnoznik);

            //Console.Write("\nTablica po mnozeniu: ");

            //for (int i = 0; i < tab.Length; i++)
            //    Console.Write(tab[i] + " ");



            //Zadanie 5.7
            //Console.Write("Podaj dwie liczby naturalne \"x n\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(" ");
            //float x = float.Parse(tab[0]);
            //float n = float.Parse(tab[1]);

            //Wyrazenie(x, n);



            //Zadanie 5.8
            //Console.Write("Podaj liczbę naturalną x: ");
            //string napis = Console.ReadLine();
            //char[] tab = napis.ToCharArray();

            //SumaCyfr(tab);



            //Zadanie 5.9
            //Console.Write("Podaj liczbę całkowitą n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(Fibo(n));



            //Zadanie 5.10
            //Console.Write("Podaj liczbę całkowitą n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine(Oblicz(n));
        }
    }
}