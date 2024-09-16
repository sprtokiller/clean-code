using System;

class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {   
        this.name = name;
        this.age = age;
    }


    public void PersonInfo()
    {
        Console.WriteLine(this.name + " is " + this.age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Person Alice = new Person("Alice", 30);
        Alice.PersonInfo();
    }
}
