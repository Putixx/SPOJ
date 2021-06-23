using System;

public class Student
{
    private string Login;
    public string _login
    {
        get => Login;
        set { _login = CheckLogin(value); }
    }

    private string _haslo;
    public string Haslo
    {
        get => _haslo;
        protected set { Haslo = CheckPass(value); }
    }

    private int liczbapodejsc;
    public int LiczbaPodejsc
    {
        get => liczbapodejsc;
    }

    private int wyniknajlepszy;
    public int WynikNajlepszy
    {
        get => wyniknajlepszy;
    }

    private int wyniknajgorszy;
    public int WyniknNajgorszy
    {
        get => wyniknajgorszy;
    }

    private int wynikostatni;
    public int WynikOstatni
    {
        get => wynikostatni;
    }

    private int wyniksredni;
    public int WynikSredni
    {
        get => wyniksredni;
    }

    private string ocena;
    public string Ocena
    {
        get => ocena;
    }

    public Student(string login, string haslo, int liczbapodejsc = 0, int wyniknajlep = 0, int wyniknajgor = 0, int wynikostat = 0, int wyniksred = 0)
    {
        Login = login;
        _haslo = haslo;
    }

    private string CheckLogin(string name)
    {
        if (name == null)
        {
            throw new ArgumentException("Bledny login!");
        }
        if (!(name[0] >= 65 && name[0] <= 90) && !(name[0] >= 97 && name[0] <= 122))
        {
            throw new ArgumentException("Bledny login!");
        }

        name = name.Replace(" ", "");

        if (name.Length < 4)
        {
            throw new ArgumentException("Bledny login!");
        }

        for (int i = 0; i < name.Length; i++)
        {
            if (!(name[i] <= 57 && name[i] >= 48) && !(name[i] <= 122 && name[i] >= 97))
            {
                throw new ArgumentException("Bledny login!");
            }
        }

        char[] nameC = name.ToCharArray();

        for (int i = 0; i < name.Length; i++)
        {
            if (!(name[i] <= 57 && name[i] >= 48)) { }
            else nameC[i] = char.Parse(name[i].ToString().ToLower());
        }

        return new string(name);
    }

    private string CheckPass(string name)
    {
        if (name == null)
        {
            throw new ArgumentException("Bledny login!");
        }

        if (name.Length < 4 || name.Length > 8)
        {
            throw new ArgumentException("Bledny login!");
        }


        return new string(name);
    }


    private bool PoprawneHaslo(string name)
    {
        if (name == _haslo) return true;
        else return false;
    }

    public bool ZmienHaslo(string stare, string nowe)
    {
        if(PoprawneHaslo(stare))
            if (CheckPass(nowe) == nowe) return true;

        return false;
    }

    public string ZarejestrujWynik(int wynik)
    {
        if (wynik > 100 || wynik < 0) throw new ArgumentOutOfRangeException("Zla wartosc!");

        if (wynik < wyniknajgorszy || wyniknajgorszy == 0) wyniknajgorszy = wynik;
        if (wynik > wyniknajlepszy) wyniknajlepszy = wynik;

        wyniksredni = (wyniknajlepszy + wyniknajgorszy) / 2;

        wynikostatni = wynik;
        liczbapodejsc++;

        if (wynik < 40) ocena = "niedostateczny";
        if (wynik > 40 && wynik < 50) ocena = "dostateczny";
        if (wynik > 50 && wynik < 60) ocena = "dostateczny plus";
        if (wynik > 60 && wynik < 70) ocena = "dobry";
        if (wynik > 70 && wynik < 80) ocena = "dobry plus";
        if (wynik >= 80) ocena = "bardzo dobry";

        return ocena;
    }

    public bool ProbujZarejestrowacWynik(int wynik)
    {
        if (wyniknajgorszy != wynik) ZarejestrujWynik(wynik);
        else if (wyniknajlepszy != wynik) ZarejestrujWynik(wynik);
        else return true;

        return true;
    }


    public override string ToString()
    {
        return $"Login: {Login}. Wyniki: n={LiczbaPodejsc}, ostatni{WynikOstatni}, najlepszy={WynikNajlepszy}, najgorszy={WyniknNajgorszy}, sredni={WynikSredni:D2}";
    }



    public static void Main()
    {
        Student p = new Student(login: "molenda", haslo: "128934");
        p.ZarejestrujWynik(22);
        p.ZarejestrujWynik(41);
        Console.WriteLine(p);
        p.Login = "kmol9";
        p.ZmienHaslo(stare: "128934", nowe: "001122");
        Console.WriteLine(p.ProbujZarejestrowacWynik(32));
        Console.WriteLine(p);
    }
}