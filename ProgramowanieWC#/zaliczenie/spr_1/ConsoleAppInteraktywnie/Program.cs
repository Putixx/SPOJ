using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        {

            Dictionary<string, Dictionary<string, int>> Dict = new Dictionary<string, Dictionary<string, int>>();

            while ()
            {
                string[] dane = Console.ReadLine().Split(" ");
                int licznik = 1;


                if (!Dict.ContainsKey(dane[3]))
                {
                    Dict.Add(dane[3], new Dictionary<string, int>());
                }
                if (Dict[dane[3]].ContainsKey(dane[2]))
                {
                    Dict[dane[3]][dane[2]] += licznik;
                }
                else
                {
                    Dict[dane[3]].Add(dane[2], licznik);
                }
            }




            foreach (var item1 in Dict)
            {
                int suma = 0;
                string napis = "";
                foreach (var item2 in item1.Value)
                {
                    suma += item2.Value;
                    napis += item2.Key + ", ";
                }
                System.Console.Write(item1.Key + ": ");
                System.Console.Write(suma + " ");
                napis = napis.Remove(napis.Length - 2, 2);
                System.Console.Write("[" + napis + "]");
                System.Console.WriteLine();
            }


        }
    }
}