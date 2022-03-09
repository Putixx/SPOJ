using System;


public class Person
{
    private string firstName;
    public string FirstName
    {
        get => firstName;
        protected set { firstName = CheckName(value); }
    }

    private string familyName;
    public string FamilyName
    {
        get => familyName;
        protected set { familyName = CheckName(value); }
    }

    private int age;
    public int Age
    {
        get => age;
        protected set { age = CheckAge(value); }
    }

    public Person(string firstName, string familyName, int age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
    }

    private string CheckName(string name)
    {
        if (name == null)
        {
            throw new ArgumentException("Wrong name!");
        }

        name = name.Replace(" ", "");

        if (name.Length < 1)
        {
            throw new ArgumentException("Wrong name!");
        }

        for (int i = 0; i < name.Length; i++)
        {
            if (!(name[i] >= 65 && name[i] <= 90) && !(name[i] >= 97 && name[i] <= 122))
            {
                throw new ArgumentException("Wrong name!");
            }
        }

        name = name.ToLower();
        char[] nameC = name.ToCharArray();
        nameC[0] = char.Parse(nameC[0].ToString().ToUpper());

        return new string(nameC);
    }

    protected virtual int CheckAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age must be positive!");
        }
        return age;
    }

    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Age})";
    }

    public void modifyFirstName(string name)
    {
        FirstName = name;
    }

    public void modifyFamilyName(string name)
    {
        FamilyName = name;
    }

    public void modifyAge(int age)
    {
        Age = age;
    }
}

public class Child : Person
{
    private readonly Person Mother, Father;

    public Child(string firstName, string familyName, int age, Person mother = null, Person father = null)
    : base(firstName, familyName, age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
        Mother = mother;
        Father = father;
    }

    protected override int CheckAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age must be positive!");
        }
        if (age > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }

        return age;
    }

    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Age}){Environment.NewLine}{(Mother != null ? ($"mother: {Mother.FirstName} {Mother.FamilyName} ({Mother.Age})") : ("mother: No data"))}{Environment.NewLine}{(Father != null ? ($"father: {Father.FirstName} {Father.FamilyName} ({Father.Age})") : ("father: No data"))}";
    }
}









public class Program
{
    public static void Main()
    {

    }
}



