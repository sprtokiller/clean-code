using System;

class Person
{
    //inicializace
    private string number;
    private int age;

    //vytvareni osob
    public Person(string number, int age)
    {
        this.number = number;
        this.age = age;
    }
    //vypis
    public void debug()
    {
        Console.WriteLine(this.number + " is " + this.age + " years old.");
    }
}

class Program
{
    //zapsani osoby
    static void Main()
    {
        Person person = new Person("Alice", 30);
        person.debug();
    }
}
