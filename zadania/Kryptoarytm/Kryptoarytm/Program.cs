using System;
using System.Linq;
using System.IO;

namespace Kryptoarytm
{
    class Program
    {
        private static readonly string[] Fruits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private const string resultsPath = "results.txt";
        static private StreamWriter s;

        public static void Main()
        {
            byte k = 8;
            byte n = 10;
            var tab = new int[k];

            while (true)
            {
                Console.WriteLine($"({string.Join(", ", tab.Select(e => Fruits[e]))})");

                int[] wyniki = new int[26];

                var index = k - 1;
                while (index >= 0 && tab[index] == n - 1)
                {
                    index--;
                }

                if (index < 0)
                {
                    break;
                }

                tab[index]++;

                for (int i = index + 1; i < k; i++)
                {
                    tab[i] = 0;
                }

                bool same = false;
                for (int i = 0; i < tab.Length; i++)
                {
                    for (int j = 0; j < tab.Length; j++)
                    {
                        if (i != j)
                        {
                            if (tab[i] == tab[j])
                            {
                                same = true;
                            }
                        }
                    }
                }
                if (same)
                    continue;

                for (int i = 0; i < k; i++)
                {
                    wyniki[1] = 0;
                    wyniki[2] = tab[0] * tab[0];
                    wyniki[3] = tab[0] * tab[1];
                    wyniki[4] = tab[0] * tab[2];
                    wyniki[5] = tab[0] * tab[3];
                    wyniki[6] = tab[0] * tab[4];
                    wyniki[7] = tab[6] * tab[0];
                    wyniki[8] = tab[6] * tab[1];
                    wyniki[9] = tab[6] * tab[2];
                    wyniki[10] = tab[6] * tab[3];
                    wyniki[11] = tab[6] * tab[4];
                    wyniki[12] = 0;
                    wyniki[13] = tab[5] * tab[0];
                    wyniki[14] = tab[5] * tab[1];
                    wyniki[15] = tab[5] * tab[2];
                    wyniki[16] = tab[5] * tab[3];
                    wyniki[17] = tab[5] * tab[4];
                    wyniki[18] = wyniki[12];
                    wyniki[19] = wyniki[13];
                    wyniki[20] = wyniki[1] + wyniki[7] + wyniki[14];
                    wyniki[21] = wyniki[2] + wyniki[8] + wyniki[15];
                    wyniki[22] = wyniki[3] + wyniki[9] + wyniki[16];
                    wyniki[23] = wyniki[4] + wyniki[10] + wyniki[17];
                    wyniki[24] = wyniki[5] + wyniki[11];
                    wyniki[25] = wyniki[6];

                    for (int j = 25; j >= 0; j--)
                    {
                        if (wyniki[j] > 9 && wyniki[j] < 20)
                        {
                            wyniki[j] = wyniki[j] - 10;
                            wyniki[j - 1] += 1;
                        }
                        if (wyniki[j] > 19 && wyniki[j] < 30)
                        {
                            wyniki[j] = wyniki[j] - 20;
                            wyniki[j - 1] += 2;
                        }
                        if (wyniki[j] > 29 && wyniki[j] < 40)
                        {
                            wyniki[j] = wyniki[j] - 30;
                            wyniki[j - 1] += 3;
                        }
                        if (wyniki[j] > 39 && wyniki[j] < 50)
                        {
                            wyniki[j] = wyniki[j] - 40;
                            wyniki[j - 1] += 4;
                        }
                        if (wyniki[j] > 49 && wyniki[j] < 60)
                        {
                            wyniki[j] = wyniki[j] - 50;
                            wyniki[j - 1] += 5;
                        }
                        if (wyniki[j] > 59 && wyniki[j] < 70)
                        {
                            wyniki[j] = wyniki[j] - 60;
                            wyniki[j - 1] += 6;
                        }
                        if (wyniki[j] > 69 && wyniki[j] < 80)
                        {
                            wyniki[j] = wyniki[j] - 70;
                            wyniki[j - 1] += 7;
                        }
                        if (wyniki[j] > 79 && wyniki[j] < 90)
                        {
                            wyniki[j] = wyniki[j] - 80;
                            wyniki[j - 1] += 8;
                        }
                        if (wyniki[j] > 89 && wyniki[j] < 100)
                        {
                            wyniki[j] = wyniki[j] - 90;
                            wyniki[j - 1] += 9;
                        }
                    }

                    if (tab[1] == wyniki[7] && tab[1] == wyniki[8] && tab[7] == wyniki[3] && tab[7] == wyniki[14] && tab[5] == wyniki[19] && tab[3] == wyniki[23] && tab[0] != tab[1] && tab[0] != tab[2] && tab[0] != tab[3] && tab[0] != tab[4] && tab[0] != tab[5] && tab[0] != tab[6] && tab[0] != tab[7] && tab[1] != tab[2] && tab[1] != tab[3] && tab[1] != tab[4] && tab[1] != tab[5] && tab[1] != tab[6] && tab[1] != tab[7] && tab[2] != tab[3] && tab[2] != tab[4] && tab[2] != tab[5] && tab[2] != tab[6] && tab[2] != tab[7] && tab[3] != tab[4] && tab[3] != tab[5] && tab[3] != tab[6] && tab[3] != tab[7] && tab[4] != tab[5] && tab[4] != tab[6] && tab[4] != tab[7] && tab[5] != tab[6] && tab[5] != tab[7] && tab[6] != tab[7])
                    {
                        //Console.WriteLine($"       {tab[0]} {tab[1]} {tab[2]} {tab[3]} {tab[4]}");
                        //Console.WriteLine($"  x        {tab[5]} {tab[6]} {tab[0]}");
                        //Console.WriteLine($" ---------------");
                        //Console.WriteLine($"     {wyniki[1]} {wyniki[2]} {wyniki[3]} {wyniki[4]} {wyniki[5]} {wyniki[6]}");
                        //Console.WriteLine($"     {wyniki[7]} {wyniki[8]} {wyniki[9]} {wyniki[10]} {wyniki[11]}");
                        //Console.WriteLine($" {wyniki[12]} {wyniki[13]} {wyniki[14]} {wyniki[15]} {wyniki[16]} {wyniki[17]}");
                        //Console.WriteLine($" ---------------");
                        //Console.WriteLine($" {wyniki[18]} {wyniki[19]} {wyniki[20]} {wyniki[21]} {wyniki[22]} {wyniki[23]} {wyniki[24]} {wyniki[25]}");
                        //Console.WriteLine("\n");

                        Console.WriteLine("LICZBY ZOSTAŁY ZNALEZIONE I ZAPISANE DO PLIKU results.txt!!");

                        if (!File.Exists(resultsPath))
                            File.Create(resultsPath).Close();

                        //Zapis do pliku wyników
                        s = File.AppendText(resultsPath);
                        s.Write($"Liczby: ");
                        for (int j = 0; j < k; j++)
                            s.Write($"{tab[j]} ");
                        s.WriteLine("");
                        s.Close();
                        return;
                    }
                }
            }
        }
    }
}