using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        //Równanie kwadratowe
        //public static void QuadraticEquation(int a, int b, int c)
        //{
        //    double delta, pdelta, x1, x2, x;

        //    if(a != 0)
        //    {
        //        delta = ((double)b * b) - (4.0 * a * c);

        //        if(delta > 0)
        //        {
        //            pdelta = Math.Sqrt(delta);
        //            x1 = (-b - pdelta) / 2.0 * a;
        //            x2 = (-b + pdelta) / 2.0 * a;

        //            Console.WriteLine("x1=" + x1.ToString("F2"));
        //            Console.WriteLine("x2=" + x2.ToString("F2"));
        //        }
        //        else if(delta == 0)
        //        {
        //            x = (-b) / 2.0 * a;

        //            Console.WriteLine("x=" + x.ToString("F2"));
        //        }
        //        else
        //        {
        //            Console.WriteLine("empty");
        //        }
        //    }
        //    else
        //    {
        //        if(b != 0)
        //        {
        //            x = -((double)c / b);

        //            Console.WriteLine("x=" + x.ToString("F2"));
        //        }
        //        else if(b == 0 && c != 0)
        //        {
        //            Console.WriteLine("empty");
        //        }
        //        else
        //        {
        //            Console.WriteLine("infinity");
        //        }
        //    }
        //}



        //Objętość stożka
        //public static void ObjStoz(int R, int L)
        //{
        //    if (R < 0 || L < 0) throw new ArgumentOutOfRangeException("ujemny argument");

        //    double h = Math.Sqrt(Math.Pow(L, 2) - Math.Pow(R, 2));

        //    if (R+L < h || R+h < L || L+h < R || L < R) throw new ArgumentException("obiekt nie istnieje");

        //    double Pp = Math.PI * R * R;
        //    double V = Pp * h * 1/3;

        //    double a = Math.Round(V, 0) - 1;
        //    double b = Math.Round(V, 0);

        //    if (a < 0)
        //        a++;
        //    Console.WriteLine(a + " " + b);
        //}



        //Tablice postrzępione
        //static char[][] ReadJaggedArrayFromStdInput()
        //{
        //    int wiersze = int.Parse(Console.ReadLine());

        //    if (wiersze < 10)
        //    {
        //        string wejscie = "";
        //        char[][] jagged = new char[wiersze][];

        //        for (int i = 0; i < wiersze; i++)
        //        {
        //            wejscie = Console.ReadLine();
        //            string[] znaki = wejscie.Split(" ");
        //            jagged[i] = new char[znaki.Length];

        //            for(int j = 0; j < znaki.Length; j++)
        //            {
        //                jagged[i][j] = Convert.ToChar(znaki[j]);
        //            }
        //        }
        //        return jagged;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //static void PrintJaggedArrayToStdOutput(char[][] tab)
        //{
        //    for( int i = 0; i < tab.Length; i++)
        //    {
        //        for (int j = 0; j < tab[i].Length; j++)
        //            Console.Write(tab[i][j] + " ");
        //        Console.WriteLine();
        //    }
        //}

        //static char[][] TransposeJaggedArray(char[][] tab)
        //{
        //    int a = 0, max = 0;

        //    for(int i = 0; i < tab.Length; i++)
        //    {
        //        a = tab[i].Length;
        //        if (a > max)
        //            max = a;
        //    }

        //    char[][] jagged = new char[max][];

        //    for (int i = 0; i < max; i++)
        //        jagged[i] = new char[tab.Length];

        //    for (int i = 0; i < max; i++)
        //        for (int j = 0; j < tab.Length; j++)
        //            jagged[i][j] = ' ';

        //    for (int i = 0; i < tab.Length; i++)
        //        for (int j = 0; j < tab[i].Length; j++)
        //            jagged[j][i] = tab[i][j];


        //    return jagged;
        //}



        static void Main(string[] args)
        {
            //Równanie kwadratowe
            //QuadraticEquation(1, 3, 2);
            //QuadraticEquation(1, -2, 1);
            //QuadraticEquation(1, 1, 1);
            //QuadraticEquation(0, 0, 0);
            //QuadraticEquation(0, 2, 1);
            //QuadraticEquation(0, 0, 5);




            //Objętość stożka
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(" ");
            //int[] dane = new int[napis.Length];
            //dane[0] = int.Parse(tab[0]);
            //dane[1] = int.Parse(tab[1]);

            //try
            //{
            //    ObjStoz(dane[0], dane[1]);
            //}
            //catch (ArgumentOutOfRangeException) { Console.WriteLine("ujemny argument"); }
            //catch (ArgumentException) { Console.WriteLine("obiekt nie istnieje"); }



            //Tablice postrzępione
            //char[][] jagged = ReadJaggedArrayFromStdInput();
            //PrintJaggedArrayToStdOutput(jagged);
            //jagged = TransposeJaggedArray(jagged);
            //Console.WriteLine();
            //PrintJaggedArrayToStdOutput(jagged);

        }
    }
}