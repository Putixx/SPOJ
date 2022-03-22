using System;

namespace ConsoleAppInteraktywnie
{
    class Program
    {

        static char[,] cyfra1()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[1, 2] = '|';
            cyfra[2, 2] = '|';
            return cyfra;
        }
        static char[,] cyfra2()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 2] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 0] = '|';
            cyfra[2, 1] = '_';
            return cyfra;
        }
        static char[,] cyfra3()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 2] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 2] = '|';
            cyfra[2, 1] = '_';
            return cyfra;

        }
        static char[,] cyfra4()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[1, 0] = '|';
            cyfra[1, 2] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 2] = '|';
            return cyfra;
        }
        static char[,] cyfra5()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 0] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 2] = '|';
            cyfra[2, 1] = '_';
            return cyfra;
        }
        static char[,] cyfra6()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 0] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 0] = '|';
            cyfra[2, 2] = '|';
            cyfra[2, 1] = '_';
            return cyfra;
        }
        static char[,] cyfra7()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 2] = '|';
            cyfra[2, 2] = '|';
            return cyfra;
        }
        static char[,] cyfra8()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 0] = '|';
            cyfra[1, 2] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 0] = '|';
            cyfra[2, 2] = '|';
            cyfra[2, 1] = '_';
            return cyfra;
        }
        static char[,] cyfra9()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 0] = '|';
            cyfra[1, 2] = '|';
            cyfra[1, 1] = '_';
            cyfra[2, 2] = '|';
            return cyfra;
        }
        static char[,] cyfra0()
        {
            char[,] cyfra = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cyfra[i, j] = ' ';
                }
            }

            cyfra[0, 1] = '_';
            cyfra[1, 0] = '|';
            cyfra[1, 2] = '|';
            cyfra[2, 0] = '|';
            cyfra[2, 2] = '|';
            cyfra[2, 1] = '_';
            return cyfra;
        }

        static void Main(string[] args)
        {
            string napis = Console.ReadLine();
            char[,] tekst = new char[3, napis.Length * 3];

            tekst = cyfra0();

            for(int i = 0; i < tekst.Length; i++)
            {
                Console.WriteLine(tekst[i,i]);
            }

        }
    }
}