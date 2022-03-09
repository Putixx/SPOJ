using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        if(t <= 5)
        {
            while (t-- > 0)
            {
                SortedSet<string> SSet = new SortedSet<string>();
                Dictionary<string, int> Dict = new Dictionary<string, int>();
                int n = int.Parse(Console.ReadLine());

                if (n <= 100000)
                {
                    while(n-- > 0)
                    {
                        string KB = Console.ReadLine();
                        int ilosc;

                        if(Dict.TryGetValue(KB, out ilosc))
                        {
                            Dict[KB] = ilosc + 1;
                        }
                        else
                        {
                            Dict[KB] = 1;
                            SSet.Add(KB);
                        }
                    }
                    Console.ReadLine();

                    foreach (var x in SSet)
                    {
                        Console.WriteLine(x + " " + Dict[x]);
                    }
                }
            }
        }
    }
}