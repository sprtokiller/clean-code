using System;

class Persons
{
    private string name;
    private int age;

    public Persons(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void getPersonAge()
    {
        Console.WriteLine(this.name + " is " + this.age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Persons person = new Persons("Alice", 30);
        person.getPersonAge();
    }
}
