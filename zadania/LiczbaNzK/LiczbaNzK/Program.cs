using System;
using System.Linq;
 
public static class Program
{
    private static readonly string[] Fruits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    public static void Main()
    {
        var k = 8;
        var n = 10;
        var arr = new int[k];

        while (true)
        {
            Console.WriteLine($"({string.Join(", ", arr.Select(e => Fruits[e]))})");

            var index = k - 1;
            while (index >= 0 && arr[index] == n - 1)
            {
                index--;
            }

            if (index < 0)
            {
                break;
            }

            arr[index]++;

            for (int i = index + 1; i < k; i++)
            {
                arr[i] = 0;
            }

            bool same = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            same = true;
                        }
                    }
                }
            }
            if (same)
                continue;
        }
    }
}