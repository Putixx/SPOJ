using System;

public class Program
{
    public static void Main()
    {
        {
            int Ltestow = int.Parse(Console.ReadLine());

            if (Ltestow <= 10)
            {
                for (int i = 0; i < Ltestow; i++)
                {
                    string[] wejscie = Console.ReadLine().Split(" ");
                    int m = int.Parse(wejscie[0]);
                    int n = int.Parse(wejscie[1]);
                    char[,] floor = new char[m, n];
                    string napis = "";
                    int osoby = 0, pokoje = 0;

                    if (m <= 100 && n <= 100)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            napis = Console.ReadLine();
                            napis.ToCharArray();

                            for (int k = 0; k < n; k++)
                                floor[j, k] = napis[k];
                        }

                        for (int j = 0; j < m; j++)
                        {
                            for (int k = 0; k < n; k++)
                            {
                                if (floor[j, k] == '*')
                                    osoby++;

                                if (k > 0 && k < n - 1 && j < m - 1)
                                    if (floor[j, k] == '*' && floor[j, k - 1] == '#' && floor[j + 1, k] == '#')
                                        pokoje++;
                            }
                        }

                        double wynik = (double)osoby / pokoje;

                        Console.WriteLine(osoby);
                        Console.WriteLine(pokoje);

                        Console.WriteLine(wynik.ToString("F2"));
                    }
                }
            }
        }
    }
}
