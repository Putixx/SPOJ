using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] S = new int[n];
            string napis = Console.ReadLine();
            string[] tab1 = napis.Split(' ');

            int m = int.Parse(Console.ReadLine());
            int[] Q = new int[m];
            napis = Console.ReadLine();
            string[] tab2 = napis.Split(' ');

            for (int i = 0; i < n; i++)
                S[i] = int.Parse(tab1[i]);

            for (int i = 0; i < m; i++)
                Q[i] = int.Parse(tab2[i]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (tab1[i] == tab2[j])
                        break;

                    if (j == m - 1)
                    {
                        Console.Write(tab1[i]);
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
