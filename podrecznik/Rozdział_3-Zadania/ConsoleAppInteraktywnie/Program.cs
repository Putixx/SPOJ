using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rozdział 3.3 zadania
            //Zadanie 3.1
            //Console.Write("Podaj rok: ");
            //int rok = int.Parse(Console.ReadLine());

            //if(rok % 4 == 0)
            //{
            //    Console.WriteLine(rok + " jest rokiem przestępnym!");
            //}
            //else
            //{
            //    Console.WriteLine(rok + " nie jest rokiem  przestępnym!");
            //}



            //Zadanie 3.2
            //Console.Write("Podaj dwie liczby całkowite \"a b\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //int a = int.Parse(tab[0]);
            //int b = int.Parse(tab[1]);

            //if(a % b == 0)
            //{
            //    Console.WriteLine("Liczba " + b + " jest dzielnikiem liczby " + a);
            //}
            //else
            //{
            //    Console.WriteLine("Liczba " + b + " nie jest dzielnikiem liczby " + a);
            //}



            //Zadanie 3.3
            //Console.Write("Podaj trzy liczby \"a b c\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //float a = float.Parse(tab[0]);
            //float b = float.Parse(tab[1]);
            //float c = float.Parse(tab[2]);

            //if(a > b && a > c)
            //{
            //    Console.WriteLine("Największą liczbą jest: " + a);
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine("Największą liczbą jest: " + b);
            //}
            //else if (c > b && c > a)
            //{
            //    Console.WriteLine("Największą liczbą jest: " + c);
            //}



            //Zadanie 3.4
            //Console.Write("Podaj żądaną operację oraz dwie liczby \"operacja a b\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //double b = double.Parse(tab[1]);
            //double c = double.Parse(tab[2]);

            //switch(tab[0])
            //{
            //    case "+":
            //        {
            //            Console.WriteLine("Wynik: " + (b + c));
            //            break;
            //        }
            //    case "-":
            //        {
            //            Console.WriteLine("Wynik: " + (b - c));
            //            break;
            //        }
            //    case "*":
            //        {
            //            Console.WriteLine("Wynik: " + (b * c));
            //            break;
            //        }
            //    case "/":
            //        {
            //            Console.WriteLine("Wynik: " + (b / c));
            //            break;
            //        }
            //}



            //Zadanie 3.5
            //Console.Write("Podaj współczynniki równania kwadratowego \"a b c\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //float a = float.Parse(tab[0]);
            //float b = float.Parse(tab[1]);
            //float c = float.Parse(tab[2]);
            //double x1, x2;

            //double delta = (b * b) - (4 * a * c);

            //if(delta > 0)
            //{
            //    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //    Console.WriteLine("Równanie to ma dwa pierwiastki: " + x1 + " i " + x2);
            //}
            //else if (delta == 0)
            //{ 
            //    x1 = (-b) / (2 * a);
            //    Console.WriteLine("Równanie to ma jeden pierwiastek: " + x1);
            //}
            //else if (delta < 0)
            //{
            //    Console.WriteLine("Równanie to nie ma pierwiastków.");
            //}



            //Zadanie 3.6
            //Console.Write("Podaj kolejno \"wagę(kg) wzrost(m)\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //float masa = float.Parse(tab[0]);
            //float wzrost = float.Parse(tab[1]);

            //float bmi = masa / (wzrost * wzrost);

            //Console.WriteLine("Twoje BMI wynosi: " + bmi);

            //if(bmi < 18.5)
            //{
            //    Console.WriteLine("Niedowaga.");
            //}
            //else if (bmi > 25.0)
            //{
            //    Console.WriteLine("Nadwaga.");
            //}
            //else
            //{
            //    Console.WriteLine("Wartość prawidłowa.");
            //}



            //Zadanie 3.8
            //Console.Write("Podaj średnią ocen: ");
            //float srednia = float.Parse(Console.ReadLine());

            //if(srednia > 2.0 && srednia < 3.99)
            //{
            //    Console.WriteLine("Kwota stypendium: 0,00zł");
            //}
            //else if (srednia > 4.0 && srednia < 4.79)
            //{
            //    Console.WriteLine("Kwota stypendium: 350,00zł");
            //}
            //else if (srednia > 4.8 && srednia < 5.0)
            //{
            //    Console.WriteLine("Kwota stypendium: 350,00zł");
            //}



            //Zadanie 3.9
            //Console.Write("Wprowadź wariant oraz liczbę wyświetlanych wierszy \"wariant(a,b,c,d) wiersze\": ");
            //string napis = Console.ReadLine();
            //string[] tab = napis.Split(' ');
            //int wiersze = int.Parse(tab[1]);
            //int b = wiersze;

            //if(tab[0] == "a")
            //{
            //    for (int i = 1; i <= wiersze; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else if (tab[0] == "b")
            //{
            //    for (int i = wiersze; i >= 1 ; i--)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else if (tab[0] == "c")
            //{
            //    for (int i = 1; i <= wiersze; i++)
            //    {
            //        for (int j = b; j >= 1; j--)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int k = 1; k <= i; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //        b--;
            //    }
            //}
            //else if (tab[0] == "d")
            //{
            //    for (int i = 1; i <= wiersze; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //    for (int i = 1; i <= wiersze - 2; i++)
            //    {
            //        Console.Write("*");
            //        for(int j = 1; j <= wiersze - 2; j++)
            //            Console.Write(" ");
            //        Console.Write("*");
            //        Console.WriteLine();
            //    }

            //    for (int i = 1; i <= wiersze; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}



            //Zadanie 3.10
            //Console.Write("Podaj liczbę całkowitą n: ");
            //int n = int.Parse(Console.ReadLine());
            //int silnia = 1;

            //for(int i = 1; i <= n; i++)
            //{
            //    silnia = silnia * i;
            //}
            //Console.WriteLine("Silnia liczby " + n + " : " + silnia);



            //Zadanie 3.11
            //int suma = 0, i = 0;

            //for (i = 1; suma <= 100; i++)
            //    suma += i;
            //Console.WriteLine("Należy dodać do siebie " + i + " liczb całkowitych." + suma);



            //Zadanie 3.12
            //int a = 1;
            //int suma = 0;

            //while (a != 0)
            //{
            //    Console.Write("Wprowadź liczbę całkowitą: ");
            //    a = int.Parse(Console.ReadLine());
            //    suma += a;
            //}
            //Console.WriteLine("Suma wprowadzonych liczb to: " + suma);



            //Zadanie 3.13
            //Console.Write("Podaj liczbę całkowitą n: ");
            //int n = int.Parse(Console.ReadLine());
            //int w = 0;

            //for(int i = 1; i <= n; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        w -= i;
            //    }
            //    else if (i % 2 != 0)
            //    {
            //        w += i;
            //    }
            //}
            //Console.WriteLine("Suma szeregu: " + w);



            //Zadanie 3.14
            //Console.Write("Podaj liczbę całkowitą n: ");
            //int n = int.Parse(Console.ReadLine());
            //int suma = 0;

            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            suma += j;
            //        }
            //    }
            //    if(i == suma)
            //        Console.WriteLine("Liczba " + i + " jest liczbą doskonałą.");
            //    else
            //        Console.WriteLine("Liczba " + i + " nie jest liczbą doskonałą.");
            //    suma = 0;
            //}

            //  (5,1,2x2)

            //Zadanie 3.15
            //int x = 1, y = 2, z = 5, suma = 0, j = 0;

            //Console.WriteLine("Wszystkie możliwe kombinacje wypłacenia 10zł przy pomocy monet 1zł, 2zł, 5zł: \n");

            //for (j = 0; suma < 10; j++)
            //    suma += x;
            //Console.WriteLine("Przy użyciu tylko monet 1zł: " + j);
            //suma = 0;

            //for (j = 0; suma < 10; j++)
            //    suma += y;
            //Console.WriteLine("Przy użyciu tylko monet 2zł: " + j);
            //suma = 0;

            //for (j = 0; suma < 10; j++)
            //    suma += z;
            //Console.WriteLine("Przy użyciu tylko monet 5zł: " + j);
            //suma = 0;

            //for (j = 0; suma < 8; j++)
            //    suma += x;
            //suma += y;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " i 2zł: 1");
            //suma = 0;

            //for (j = 0; suma < 6; j++)
            //    suma += x;
            //suma += 2 * y;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " i 2zł: 2");
            //suma = 0;

            //for (j = 0; suma < 4; j++)
            //    suma += x;
            //suma += 3 * y;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " i 2zł: 3");
            //suma = 0;

            //for (j = 0; suma < 2; j++)
            //    suma += x;
            //suma += 4 * y;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " i 2zł: 4");
            //suma = 0;

            //for (j = 0; suma < 5; j++)
            //    suma += x;
            //suma += z;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " i 5zł: 1");
            //suma = 0;

            //for (j = 0; suma < 3; j++)
            //    suma += x;
            //suma += y + z;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " 2zł: 1 i 5zł: 1");
            //suma = 0;

            //for (j = 0; suma < 1; j++)
            //    suma += x;
            //suma += 2 * y + z;
            //Console.WriteLine("Przy użyciu monet 1zł: " + j + " 2zł: 2 i 5zł: 1");
        }
    }
}