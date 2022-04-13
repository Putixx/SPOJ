using System;

namespace Alcatraz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            foreach (var x in money)
                Console.WriteLine(x);

            int argue = int.Parse(Console.ReadLine());
            string[] pairs = new string[argue];

            for (int i = 0; i < argue; i++)
                pairs[i] = Console.ReadLine().Replace(" ", "");

            for (int i = 0; i < argue; i++)
                Console.WriteLine(pairs[i]);
            

        }
    }
}
