using System;

namespace CutCake
{
    class Program
    {
        static long Cut(long n)
        {
            long i = 3, ans;

            if (n <= 1)
                return 0;

            if (n == 2)
                return 1;
            else
            { 
                ans = 2;
                while (i <= n)
                {
                    i += ans;

                    if (i > n)
                        break;

                    ans++;
                }
                return ans;
            }
        }

        static void Main(string[] args)
        {
            long inputN = long.Parse(Console.ReadLine());
            long[] dataTable = new long[inputN];

            for (long i = 0; i < inputN; i++)
                dataTable[i] = long.Parse(Console.ReadLine());

            for (long i = 0; i < inputN; i++)
                Console.WriteLine(Cut(dataTable[i]));
        }
    }
}
