namespace Week09Main;

public abstract class Calisanlar
{
    public int ID { get; set; }
    public string AdSoyad { get; set; }
    protected decimal Maas { get; set; }

    public Calisanlar(string adSoyad, decimal maas)
    {
        AdSoyad = adSoyad;
        Maas = maas;
        Console.WriteLine("1. Calisan (base) Constructor calisti.");
    }

    public void BilgiVer()
    {
        Console.WriteLine($"Calisan ID: {ID}\nCalisan Ad Soyad: {AdSoyad}");
    }

    public void PrimEkle(decimal valueToAdd)
    {
        Maas += valueToAdd;
    }
}
public class Yazilimci : Calisanlar
{
    public string BildigiDiller { get; set; }
    public Yazilimci(string adSoyad, decimal maas, string diller):base(adSoyad,maas)
    {
        BildigiDiller = diller;
        Console.WriteLine($"2. Yazilimci (Derived) Constructor calisti.");
    }
    public void KodYaz()
    {
        Console.WriteLine($"{AdSoyad}, {BildigiDiller} kullanarak kod yaziyor");
    }
}