namespace Week12Main;

public class Daire : Sekil
{
    public int Yaricap {get;set;}
    public Daire()
    {
        Console.WriteLine($"Daire object olusturuldu");
        Yaricap = 10;
    }
    public Daire(int yaricap)
    {
        Yaricap = yaricap;
    }
    public override void Ciz()
    {
        Console.WriteLine("Daire Cizildi");
    }
    public override string AlanHesapla()
    {
        return Math.Pow(Yaricap, 2).ToString() + "π";
    }
}
