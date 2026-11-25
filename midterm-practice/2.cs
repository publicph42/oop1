using System;

class Tracer
{
    public static int Track(string name)
    {
        Console.WriteLine(name);
        return 0;
    }
}

class BaseClass
{
    static int baseStatic = Tracer.Track("Base Static Field");       // [6]
    int baseInstance = Tracer.Track("Base Instance Field");          // [8]

    static BaseClass()
    {
        Console.WriteLine("Base Static Constructor");                // [7]
    }

    public BaseClass()
    {
        Console.WriteLine("Base Instance Constructor");              // [9]
    }
}

class DerivedClass : BaseClass
{
    static int derivedStatic = Tracer.Track("Derived Static Field"); // [3]
    int derivedInstance = Tracer.Track("Derived Instance Field");    // [5]

    static DerivedClass()
    {
        Console.WriteLine("Derived Static Constructor");             // [4]
    }

    public DerivedClass()
    {
        Console.WriteLine("Derived Instance Constructor");           // [10]
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("App Start");                              // [1]
        DerivedClass obj = new DerivedClass();                       // [2]
    }
}