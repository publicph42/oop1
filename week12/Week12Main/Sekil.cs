namespace Week12Main;

public abstract class Sekil
{
    public ConsoleColor Renk {get;set;}

    public ConsoleColor defaultColor = Console.ForegroundColor;
    public Sekil()
    {
        
    }
    public virtual void Ciz()
    {
        Console.WriteLine("Belirsiz bir sekil olusturuluyor");
    }
    public abstract string AlanHesapla();
    public void BilgiYazdir()
    {
        Console.WriteLine($"Sekil rengi {Renk}\nHesaplanmis Alan: {this.AlanHesapla()}");
    }
}