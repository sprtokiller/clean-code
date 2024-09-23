using System;

class people
{
    private string name;
    private int age;

    public people(string n, int a)
    {
        this.name = n;
        this.age = a;
    }

    public void printed()
    {
        Console.WriteLine(this.name + " is " + this.age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        people person = new people("Alice", 30);
        person.printed();
    }
}
