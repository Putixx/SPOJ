using System;
using System.Text;

namespace CurseRecursion
{
    class Program
    {
        public static ulong k;


        public static string fun(ulong n)
        {
            if (n > 0)
            {

                fun(n - 1);
                k--;

                if (k == 0)
                    return n.ToString();

                fun(n - 1);

            }
            return n.ToString();
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder wynik = new StringBuilder();

            for(int i = 0; i < t; i++)
            {
                ulong[] testcase = Array.ConvertAll(Console.ReadLine().Split(), ulong.Parse);

                if (testcase[0] < testcase[1])
                    wynik.AppendLine("0");
                else
                {
                    k = testcase[1];
                    wynik.AppendLine(fun(testcase[0]));
                }
            }
            Console.WriteLine(wynik);
        }
    }
}
