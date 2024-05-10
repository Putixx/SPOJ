using System;

namespace Marbles
{
    class Program
    {
        public static long Marbles(int n, int k)
        {
            k = Math.Min(k, n - k);

            if (k == 0)
                return 1;

            long odp = n;

            for (int i = 2; i <= k; i++)
                odp = odp * (n - i + 1) / i;

            return odp;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 1; i <= t; i++)
            {
                int[] testcase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                Console.WriteLine(Marbles(testcase[0] - 1, testcase[1] - 1));
            }
        }
    }
}
