using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<int, int> Dict = new Dictionary<int, int>();
        string wejscie = Console.ReadLine();
        string[] tab = wejscie.Split(" ");
        int n = int.Parse(tab[0]);

        if(n <= 1000 && n >= 1)
        {
            long c = long.Parse(tab[1]);

            if(c <= 10000000000 && c >= 1)
            {
                string ciagwejscie = Console.ReadLine();
                string[] ciagtab = ciagwejscie.Split(" ");
                int[] ciag = new int[n];
                int ilosc;

                for (int i = 0; i < ciag.Length; i++)
                    ciag[i] = int.Parse(ciagtab[i]);

                for (int i = 0; i < ciag.Length; i++)
                {
                    if (Dict.TryGetValue(ciag[i], out ilosc))
                    {
                        Dict[ciag[i]] = ilosc + 1;
                    }
                    else
                    {
                        Dict[ciag[i]] = 1;
                    }
                }

                Dict = Dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var x in Dict)
                    for (int i = 0; i < x.Value; i++)
                        Console.Write(x.Key + " ");
            }
        }
    }
}