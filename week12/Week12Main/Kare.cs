namespace Week12Main;

public class Kare : Sekil
{
public int Uzunluk {get;set;}
    public Kare(ConsoleColor renk)
    {
        Console.WriteLine($"Kare object olusturuldu");
        Uzunluk = 10;
        Renk = renk;
    }
    public Kare(ConsoleColor renk, int uzunluk)
    {
        Renk = renk;
        Uzunluk = uzunluk;
    }
    public override void Ciz()
    {
        Console.ForegroundColor = Renk;


        Console.WriteLine("Kare Cizildi (4 esit kenar cizildi)\n");

        string sideChar = "# ";
        string emptyChar = ". ";
        
        for (int i = 0; i < Uzunluk; i++)
        {
            for (int j = 0; j < Uzunluk; j++)
            {
                if (j == 0 || j == Uzunluk - 1 || i == 0 || i == Uzunluk - 1)
                {
                    Console.Write($"{sideChar}");
                }
                else
                {
                    Console.Write($"{emptyChar}");
                }
            }
            Console.Write($"\n");
        }
        Console.ForegroundColor = defaultColor;
    }

    public override string AlanHesapla()
    {
        return Math.Pow(Uzunluk, Uzunluk).ToString();
    }
}

