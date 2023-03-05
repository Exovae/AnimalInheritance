using System;

// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Cat : Animal
{
    private int age;
    protected bool isIndoor;
    public string breed;

    public void setAge(int age)
    {
        this.age = age;
    }

    public int getAge()
    {
        return this.age;
    }

    public void setIsIndoor(bool isIndoor)
    {
        this.isIndoor = isIndoor;
    }

    public bool getIsIndoor()
    {
        return this.isIndoor;
    }

    public override string getType()
    {
        return "Domestic Mammal";
    }

    public override string getName()
    {
        return "Cat Name: " + base.getName();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create a Guinea Pig object
        Animal guineaPig = new Animal();
        guineaPig.setName("Pixel");
        guineaPig.setType("Guinea Pig");
        guineaPig.color = "Brown";

        Console.WriteLine("Guinea Pig information:");
        Console.WriteLine("Animal Name: {0}", guineaPig.getName());
        Console.WriteLine("Animal Type: {0}", guineaPig.getType());
        Console.WriteLine("Animal Color: {0}", guineaPig.color);

        // create a Cat object
        Cat cat = new Cat();
        cat.setName("Fiona");
        cat.setType("Domestic");
        cat.color = "Gray";
        cat.setAge(2);
        cat.setIsIndoor(true);
        cat.breed = "British Shorthair";

        Console.WriteLine("\nCat information:");
        Console.WriteLine("Animal Name: {0}", cat.getName());
        Console.WriteLine("Animal Type: {0}", cat.getType());
        Console.WriteLine("Animal Color: {0}", cat.color);
        Console.WriteLine("Cat Age: {0}", cat.getAge());
        Console.WriteLine("Is Cat Indoor: {0}", cat.getIsIndoor());
        Console.WriteLine("Cat Breed: {0}", cat.breed);

        Console.ReadKey();
    }
}
