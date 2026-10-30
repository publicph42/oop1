namespace Week06Main;

internal class ConstructorChaining
{
    public ConstructorChaining()
    {
        Console.Write("Hi!  ");
    }

    public ConstructorChaining(string a)
        : this()
    {
        Console.Write(a);
    }

    public ConstructorChaining(string a, string b)
        : this("welcome")
    {
        Console.Write(a + " " + b);
    }
}
