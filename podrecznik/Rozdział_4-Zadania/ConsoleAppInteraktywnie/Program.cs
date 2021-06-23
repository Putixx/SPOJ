using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rozdział 4.3
            //Zadanie 4.1
            //Console.Write("Podaj ile elementów ma mieć tablica oraz podaj liczby całkowite, które będą jej wartościami: \"tab a b c...\" ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //int n = int.Parse(tab[0]);

            //int[] tablica = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    tablica[i] = int.Parse(tab[i+1]);
            //}

            //foreach (int x in tablica)
            //{
            //    Console.Write(x + ", ");
            //}



            //Zadanie 4.2
            //float[] tab1 = new float[10] { 1, -2, -5, 6, 8, 2, 6, 12, -10, -3 };
            //float[] tab2 = new float[10];

            //for (int i = 0; i < tab1.Length; i++ )
            //{
            //    if (tab1[i] > 0)
            //        tab2[i] = tab1[i];
            //}

            //foreach(float x in tab2)
            //    Console.Write(x + ", ");



            //Zadanie 4.3
            //Console.Write("Podaj ile elementów ma mieć tablica oraz podaj liczby całkowite, które będą jej wartościami: \"tab a b c...\" ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //int n = int.Parse(tab[0]);
            //int suma = 0, max = 0, min = 2147483646, maxi = 0, mini = 0;
            //float srednia = 0;
            //int[] tab1 = new int[n];

            //int[] tablica = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    tablica[i] = int.Parse(tab[i + 1]);
            //}

            //foreach (int x in tablica)
            //{
            //    suma += x;
            //}

            //for(int i = 0; i < tablica.Length; i++)
            //{
            //    if (tablica[i] > max)
            //    {
            //        max = tablica[i];
            //        maxi = i;
            //    }

            //    if (tablica[i] < min)
            //    {
            //        min = tablica[i];
            //        mini = i;
            //    }

            //}

            //Console.Write("Wartości dodatnie w tablicy: ");
            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    if (tablica[i] > 0)
            //        Console.Write(tablica[i] + ", ");
            //}

            //srednia = (float)suma / tablica.Length;

            //Console.WriteLine("\nNajmniejszy element: " + min +" jest w: " + mini +" komórce.");
            //Console.WriteLine("Największy element: " + max +" jest w: " + maxi +" komórce.");
            //Console.WriteLine("Średnia: " + srednia);



            //Zadanie 4.4
            //Random rand = new Random();
            //int[] tab = new int[100];

            //for (int i = 0; i < 100; i++)
            //    tab[i] = rand.Next(1, 1000);

            //for (int i = 0; i < 100; i++)
            //    Console.Write(tab[i] + ", "); 



            //Zadanie 4.5
            //Console.Write("Podaj ilo elementowa ma być tablica: ");
            //int n = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //int[] tab1 = new int[n];
            //int[] tab2 = new int[n];

            //for (int i = 0; i < tab1.Length; i++)
            //    tab1[i] = rand.Next(1, 1000);

            //Array.Copy(tab1, 0, tab2, 1, n - 1);
            //tab2[0] = tab1[n - 1];

            //for (int i = 0; i < tab1.Length; i++)
            //    Console.Write(tab1[i] + ", ");
            //Console.WriteLine();
            //for (int i = 0; i < tab2.Length; i++)
            //    Console.Write(tab2[i] + ", ");



            //Zadanie 4.6
            //Random rand = new Random();
            //float[,] tab = new float[5, 5];
            //float suma = 0;

            //for (int i = 0; i < 5; i++)
            //    for(int j = 0; j < 5; j++)
            //        tab[i,j] = rand.Next(1, 1000);

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //        Console.Write(tab[i, j] + ", ");
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //    suma += tab[i, i];
            //Console.WriteLine("Suma: " + suma);



            //Zadanie 4.7
            //Random rand = new Random();
            //float[,] tabA = new float[2, 3];
            //float[,] tabB = new float[2, 3];
            //float[,] tabC = new float[2, 3];

            //for (int i = 0; i < 2; i++)
            //    for (int j = 0; j < 3; j++)
            //        tabA[i, j] = rand.Next(1, 1000);

            //for (int i = 0; i < 2; i++)
            //    for (int j = 0; j < 3; j++)
            //        tabB[i, j] = rand.Next(1, 1000);

            //for (int i = 0; i < 2; i++)
            //    for (int j = 0; j < 3; j++)
            //        tabC[i, j] = tabA[i,j] + tabB[i,j];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(tabA[i, j] + ", ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(tabB[i, j] + ", ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(tabC[i, j] + ", ");
            //    Console.WriteLine();
            //}



        }
    }
}