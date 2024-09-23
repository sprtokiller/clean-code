using System;

class Person
{
    private string n;
    private int a;

    public Person(string n, int a)
    {
        this.n = n;
        this.a = a;
    }

    public void d()
    {
        Console.WriteLine(this.n + " is " + this.a + " years old.");
    }
}

class Program
{
    static void Main()
    {
        P p = new Person("Alice", 30);
        p.d();
    }
}
