using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());

            if(n > 0 && n <= 1000)
            {
                SortedDictionary<string, Tuple<string, int>> SDict = new SortedDictionary<string, Tuple<string, int>>();

                for (int i = 0; i < n; i++)
                {
                    string[] dane = Console.ReadLine().Split(" ");
                    Tuple<string, int> czas = new Tuple<string, int>("", 0);
                    int x = 0;
                    

                    if (!SDict.TryGetValue(dane[0], out czas))
                    {
                        SDict.Add(dane[0], new Tuple<string, int>(dane[1], int.Parse(dane[2])));
                    }
                    else
                    {
                        x = czas.Item2;
                        Tuple<string, int> dodatek = new Tuple<string, int>(czas.Item1, int.Parse(dane[2]) + x);
                        SDict[dane[0]] = dodatek; 
                    }
                }

                var totals = SDict.GroupBy(a => a.Value.Item1).Select(a => new { a.Key, Total = a.Sum(x => x.Value.Item2) }).ToList();

                foreach (var x in totals)
                {
                    string napis = "";
                    foreach (var z in SDict)
                    {
                        if (x.Key == z.Value.Item1)
                            napis += z.Key + ", ";
                    }

                    Console.Write(x.Key + ": ");
                    Console.Write(x.Total);
                    napis = napis.Remove(napis.Length - 2, 2);
                    Console.Write(" [" + napis + "] ");
                    Console.WriteLine();
                }
            }
        }
    }
}