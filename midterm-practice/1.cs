using System;

class Computer
{
    public Computer()
    {
        Console.WriteLine("Computer Default");       // [A]
    }

    public Computer(string name)
    {
        Console.WriteLine("Computer Named");         // [3]
        RunDiagnostics();                            // [4]
    }

    public virtual void RunDiagnostics()
    {
        Console.WriteLine("Computer Diagnostics");   // []
    }
}

class Smartphone : Computer
{
    public Smartphone(string model) : base(model)
    {
        Console.WriteLine("Smartphone Constructor"); // [6]
    }

    public override void RunDiagnostics()
    {
        Console.WriteLine("Smartphone Diagnostics"); // [5,8]
    }

    public void PowerOn()
    {
        Console.WriteLine("Powering On");            // [G]
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("App Start");              // [1]
        Computer myPhone = new Smartphone("Galaxy"); // [2]
        myPhone.RunDiagnostics();                    // [7]
    }
}