namespace Week12Main;

public class Ucgen : Sekil
{
    public int[] Dimensions { get; set; } = [0, 0];
    public Ucgen(ConsoleColor renk)
    {
        Console.WriteLine($"Ucgen object olusturuldu");
        Renk = renk;
        Dimensions[0] = 5;
        Dimensions[1] = 10;
    }
    public Ucgen(ConsoleColor renk, int[] dimensions)
    {
        Dimensions = dimensions;
    }
    public override void Ciz()
    {
        Console.WriteLine("Ucgen Cizildi");

        int height = 5;
        for (int i = 0; i < height; i++)
        {

        }
    }
    public override string AlanHesapla()
    {
        return (Dimensions[0] * Dimensions[1] * 0.5).ToString();
    }
}


