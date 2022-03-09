using System;

public class Program
{
    public static void Main()
    {
        string[] napis = null;
        Czas24h t = null;

        // wczytanie i parsowanie napisu oznaczającego godzinę, np. 2:15:27
        napis = Console.ReadLine().Split(':');
        int[] czas = Array.ConvertAll(napis, int.Parse);
        try
        {
            t = new Czas24h(czas[0], czas[1], czas[2]);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("error");
            return;
        }

        // wczytanie liczby poleceń
        int liczbaPolecen = int.Parse(Console.ReadLine());

        for (int i = 1; i <= liczbaPolecen; i++)
        {
            // wczytanie polecenia
            napis = Console.ReadLine().Split(' ');
            string typPolecenia = napis[0];
            int liczba = int.Parse(napis[1]);

            // wykonanie polecenia na obiekcie t typu Czas24h
            try
            {
                switch (typPolecenia)
                {
                    case "g":
                        t.Godzina = liczba;
                        break;
                    case "m":
                        t.Minuta = liczba;
                        break;
                    case "s":
                        t.Sekunda = liczba;
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("error");
                return;
            }
        }
        Console.WriteLine(t);
    }
}

public class Czas24h
{
    private int liczbaSekund;
    private int sekunda;
    private int minuta;
    private int godzina;

    public int Sekunda
    {
        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
        set
        {
            if (value > 59 || value < 0) throw new ArgumentException();

            liczbaSekund = liczbaSekund - Sekunda;
            sekunda = value;
            liczbaSekund = liczbaSekund + sekunda;
        }
        // uzupełnij kod - zdefiniuj setters'a
    }

    public int Minuta
    {
        get => (liczbaSekund / 60) % 60; 
        set
        {
            if (value > 59 || value < 0) throw new ArgumentException();

            liczbaSekund = liczbaSekund - Minuta * 60;
            minuta = value;
            liczbaSekund = liczbaSekund + minuta * 60;
        }
        // uzupełnij kod - zdefiniuj setters'a
    }

    public int Godzina
    {
        get => liczbaSekund / 3600;
        set
        {
            if (value > 23 || value < 0) throw new ArgumentException();

            liczbaSekund = liczbaSekund - Godzina * 3600;
            godzina = value;
            liczbaSekund = liczbaSekund + godzina * 3600;
        }
        // uzupełnij kod - zdefiniuj setters'a
    }

    public Czas24h(int godzina, int minuta, int sekunda)
    {
        if (godzina < 0 || godzina > 23 || minuta < 0 || minuta > 59 || sekunda < 0 || sekunda > 59) throw new ArgumentException();

        // uzupełnij kod zgłaszając wyjątek ArgumentException
        // w sytuacji niepoprawnych danych

        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }

    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}
