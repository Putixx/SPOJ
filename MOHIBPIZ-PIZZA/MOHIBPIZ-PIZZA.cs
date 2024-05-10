using System;
using System.Text;

namespace MOHIBPIZ_PIZZA
{
    class Program
    {
        //static long Pizza(long t, long x)
        //{
        //    if (t == 0)
        //        return x - 1;
        //    else
        //        return Pizza(t - 1, x + t);
        //}

        static long Pizza(long t) => ((t * t) + t + 2) / 2;

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            var wynik = new StringBuilder();

            for (int i = 1; i <= t; i++)
                wynik.AppendLine(Pizza(long.Parse(Console.ReadLine())).ToString());

            Console.WriteLine(wynik);

            //for (int i = 0; i < t; i++)
            //    wynik.AppendLine(Pizza(long.Parse(Console.ReadLine(), 2)).ToString());
        }
    }
}