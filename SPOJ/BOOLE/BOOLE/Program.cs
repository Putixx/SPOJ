using System;
using System.Collections.Generic;

namespace BOOLE
{
    public class Program
    {

        static char NOT(char a) => (a == '1') ? '0' : '1';
        static char AND(char a, char b) => (a == '1' && b == '1') ? '1' : '0';
        static char OR(char a, char b) => (a == '1' && b == '1') ? '0' : '1';
        static char Implie(char a, char b) => (a == '1' && b == '0') ? '0' : '1';
        static char Equal(char a, char b) => (a == b) ? '1' : '0';
        static void Main(string[] args)
        {
            // IIqrIIpqIpr
            string operators = " ()!&|<>-";

            while (true)
            {
                List<char> positions = new List<char>();
                Dictionary<char, char[]> argvalues = new Dictionary<char, char[]>();

                BooleanLogic(Console.ReadLine(), operators, positions, argvalues);
            }
        }

        static void BooleanLogic(string exp, string operators, List<char> positions, Dictionary<char, char[]> argvalues)
        {
            int num_vars = PreProcess(exp, positions, operators);
            int num_states = Convert.ToInt32(Math.Pow(2, num_vars));
            char[][] valuesTab = AssignVariables(num_vars);
            argvalues = VarDict(num_vars, positions, valuesTab);

            foreach (var item in argvalues)
            {
                Console.Write(item.Value);
                Console.WriteLine();
            }

            foreach (var pos in positions)
                Console.WriteLine(pos);

            char[][] operationsTab = Operations(exp, argvalues, positions);

            for(int i = 0; i < operationsTab.Length; i++)
            {
                for(int j = 0; j < operationsTab[i].Length; j++)
                {
                    Console.Write(operationsTab[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static int PreProcess(string prefixExp, List<char> positions, string operators)
        {
            foreach (char c in prefixExp)
                if (!operators.Contains(c) && !positions.Contains(c))
                    positions.Add(c);

            return positions.Count;
        }

        public static char[][] AssignVariables(int a)
        {
            int b = (int)Math.Pow(2, a);
            char[][] valuesTab = new char[b][];

            for (int i = 0; i < b; i++)
            {
                valuesTab[i] = new char[b];
                string X = Convert.ToString(i, 2).PadLeft(a, '0');

                for (int j = 0; j < a; j++)
                    valuesTab[i][j] = X[j];
            }
            return valuesTab;
        }

        public static Dictionary<char, char[]> VarDict(int a, List<char> positions, char[][] valuesTab)
        {
            Dictionary<char, char[]> argvalues = new Dictionary<char, char[]>();
            int b = (int)Math.Pow(2, a);
            char[] tempTab;

            for (int i = 0; i < a; i++)
            {
                tempTab = new char[b];

                for (int j = 0; j < b; j++)
                    tempTab[j] = valuesTab[j][i];

                if (!argvalues.ContainsKey(positions[i]))
                    argvalues.Add(positions[i], tempTab);
            }
            return argvalues;
        }

        public static char[][] Operations(string exp, Dictionary<char, char[]> argvalues, List<char> positions)
        {
            List<char> Lz = new List<char>();
            string expNoSpaces = exp.Replace(" ", "");
            expNoSpaces = expNoSpaces.Replace("-->", ">");
            expNoSpaces = expNoSpaces.Replace("<->", "=");
            expNoSpaces = expNoSpaces.Replace("(", "");
            expNoSpaces = expNoSpaces.Replace(")", "");

            foreach (char x in expNoSpaces)
                if (!positions.Contains(x) && !Lz.Contains(x))
                    Lz.Add(x);

            foreach (var x in Lz)
                Console.WriteLine(x);

            int b = (int)Math.Pow(2, positions.Count);
            char[][] valuesTab = new char[b][];

            Console.WriteLine(expNoSpaces);

            for (int i = 0; i < expNoSpaces.Length; i++)
            {
                valuesTab[i] = new char[b];
                char[] tempTab;
                char[] tempTab2;
                
                switch (expNoSpaces[i])
                {
                    case '&':
                        {
                            if(expNoSpaces[i + 1] == '!')
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 2]];

                                for(int j = 0; j < tempTab2.Length; j++)
                                    tempTab2[j] = NOT(tempTab2[j]);

                                for(int j = 0; j < b; j++)
                                    valuesTab[i][j] = AND(tempTab[j], tempTab2[j]);
                            }

                            else
                            { 
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 1]];

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = AND(tempTab[j], tempTab2[j]);
                            }
                            break;
                        }
                    case '|':
                        {
                            if (expNoSpaces[i + 1] == '!')
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 2]];

                                for (int j = 0; j < tempTab2.Length; j++)
                                    tempTab2[j] = NOT(tempTab2[j]);

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = OR(tempTab[j], tempTab2[j]);
                            }

                            else
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 1]];

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = OR(tempTab[j], tempTab2[j]);
                            }
                            break;
                        }
                    case '>':
                        {
                            if (expNoSpaces[i + 1] == '!')
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 2]];

                                for (int j = 0; j < tempTab2.Length; j++)
                                    tempTab2[j] = NOT(tempTab2[j]);

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = Implie(tempTab[j], tempTab2[j]);
                            }

                            else
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 1]];

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = Implie(tempTab[j], tempTab2[j]);
                            }
                            break;
                        }
                    case '=':
                        {
                            if (expNoSpaces[i + 1] == '!')
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 2]];

                                for (int j = 0; j < tempTab2.Length; j++)
                                    tempTab2[j] = NOT(tempTab2[j]);

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = Equal(tempTab[j], tempTab2[j]);
                            }

                            else
                            {
                                tempTab = argvalues[expNoSpaces[i - 1]];
                                tempTab2 = argvalues[expNoSpaces[i + 1]];

                                for (int j = 0; j < b; j++)
                                    valuesTab[i][j] = Equal(tempTab[j], tempTab2[j]);
                            }
                            break;
                        }
                    case '!':
                        {
                            tempTab = argvalues[expNoSpaces[i + 1]];

                            for (int j = 0; j < b; j++)
                                valuesTab[i][j] = NOT(tempTab[j]);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            return valuesTab;
        }

    }
}




//using System;
//using System.Collections.Generic;

//namespace BOOLE
//{
//    public class Program
//    {

//        static char NOT(int a) => (a == '1') ? '0' : '1';
//        static char AND(int a, int b) => (a == '1' && b == '1') ? '1' : '0';
//        static char OR(int a, int b) => (a == '1' && b == '1') ? '0' : '1';
//        static char Implikacja(int a, int b) => (a == '1' && b == '0') ? '0' : '1';
//        static char Rownowaznosc(int a, int b) => (a == b) ? '1' : '0';
//        static void Main(string[] args)
//        {
//            IIqrIIpqIpr
//            string operatory = "CDIEN";
//            int linia = int.Parse(Console.ReadLine());
//            for (int i = 0; i < linia; i++)
//            {
//                string zdanie = Console.ReadLine();
//                wynik.AppendLine(Kierowniku(zdanie, operatory));
//            }
//        }
//        public static string Kierowniku(string zdanie, string operatory)
//        {
//            string wynik = "NO";
//            List<char> listaZnakow = PosortowanaListaArgumentow(zdanie);
//            int iloscArgumentow = listaZnakow.Count;
//            int[,] tablicaLiczb = PrzypisanieWartosciLiczb(iloscArgumentow);
//            bool wynikBool = CzyTautologia(zdanie, operatory, tablicaLiczb, listaZnakow);

//            if (wynikBool)
//                wynik = "YES";
//            else
//                wynik = "NO";
//            return wynik;
//        }
//        public static List<char> PosortowanaListaArgumentow(string zdanie)
//        {
//            List<char> listaZnakow = new List<char>();
//            foreach (var x in zdanie)
//                if (char.IsLower(x) && !listaZnakow.Contains(x))
//                    listaZnakow.Add(x);
//            listaZnakow.Sort();
//            return listaZnakow;
//        }
//        public static int[,] PrzypisanieWartosciLiczb(int a)
//        {
//            int b = (int)Math.Pow(2, a);
//            int[,] tablicaLiczb = new int[b, a];
//            for (int i = 0; i < b; i++)
//            {
//                string X = Convert.ToString(i, 2).PadLeft(a, '0');
//                for (int j = 0; j < a; j++)
//                {
//                    tablicaLiczb[i, j] = int.Parse(X[j].ToString());
//                }
//            }
//            return tablicaLiczb;
//        }
//        public static bool CzyTautologia(string zdanie, string operatory, int[,] tablicaLiczb, List<char> listaZnakow)
//        {
//            bool odpowiedz = false;
//            List<char> LZ = new List<char>();
//            string liczbyWyjsciowe = "";
//            for (int iloscImplikacji = 0; iloscImplikacji < Math.Pow(2, listaZnakow.Count); iloscImplikacji++)
//            {
//                LZ = new List<char>(PrzypiszListe(zdanie, listaZnakow, tablicaLiczb, iloscImplikacji));
//                int i = zdanie.Length - 1;
//                while (i >= 0)
//                {
//                    if (LZ[i] == '0' || LZ[i] == '1')
//                    {
//                        i--;
//                        continue;
//                    }


//                    switch (LZ[i])
//                    {
//                        case 'C':
//                            LZ[i] = AND(LZ[i + 1], LZ[i + 2]);
//                            LZ.RemoveAt(i + 1);
//                            LZ.RemoveAt(i + 1);
//                            i--;
//                            break;
//                        case 'D':
//                            LZ[i] = OR(LZ[i + 1], LZ[i + 2]);
//                            LZ.RemoveAt(i + 1);
//                            LZ.RemoveAt(i + 1);
//                            i--;
//                            break;
//                        case 'I':
//                            LZ[i] = Implikacja(LZ[i + 1], LZ[i + 2]);
//                            LZ.RemoveAt(i + 1);
//                            LZ.RemoveAt(i + 1);
//                            i--;
//                            break;
//                        case 'E':
//                            LZ[i] = Rownowaznosc(LZ[i + 1], LZ[i + 2]);
//                            LZ.RemoveAt(i + 1);
//                            LZ.RemoveAt(i + 1);
//                            i--;
//                            break;
//                        case 'N':
//                            LZ[i] = NOT(LZ[i + 1]);
//                            LZ.RemoveAt(i + 1);
//                            break;
//                        default:
//                            i--;
//                            break;

//                    }

//                }
//                if (LZ[0] != '1')
//                {
//                    odpowiedz = false;

//                    break;
//                }
//                else
//                {
//                    odpowiedz = true;
//                    liczbyWyjsciowe += LZ[0];
//                }
//            }
//            return odpowiedz;
//        }
//        public static List<char> PrzypiszListe(string zdanie, List<char> listaZnakow, int[,] tablicaLiczb, int iX)
//        {
//            List<char> LZ = new List<char>();

//            for (int i = 0; i < zdanie.Length; i++)
//            {
//                if (char.IsLower(zdanie[i]))
//                    for (int L = 0; L < listaZnakow.Count; L++)
//                    {
//                        if (zdanie[i] == listaZnakow[L])
//                            LZ.Add(Convert.ToChar(tablicaLiczb[iX, L].ToString()));
//                    }
//                else
//                {
//                    LZ.Add(zdanie[i]);
//                }
//            }
//            return LZ;
//        }
//    }
//}

