using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static int NWD(int a, int b)
        {
            if (b == 0) return a;
            else return NWD(b, a % b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj a i b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("NWD = {0}", NWD(a, b));
            Console.ReadKey();
        }
    }
}