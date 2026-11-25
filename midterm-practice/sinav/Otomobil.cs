namespace sinav;

public class Otomobil : Arac
{
    public int KapiSayisi { get; set; }

    // Constructor 1: Parametresiz -> Kendi içindeki diğer constructor'ı çağırır (this)
    public Otomobil() : this("Standart Otomobil", 2026, 4)
    {

        Console.WriteLine("[2] Otomobil -> Parametresiz Constructor çalaşti.");

    }

    // Constructor 2: Overloading -> Üst sanafan (Arac) ilgili constructor'ani çağarır (base)
    public Otomobil(string marka, int uretimYili, int kapiSayisi) : base(marka, uretimYili)
    {
        this.KapiSayisi = kapiSayisi;
        Console.WriteLine($"[2] Otomobil -> 3 Parametreli Constructor çalaşti. (Kapa: {this.KapiSayisi})");
    }
    // Üst sınzftaki virtual metodu ezme (Override) ve base ile üst sınıf metodunu çağırma
    public override void BilgiYazdir()
    {
        base.BilgiYazdir(); // Önce Arac sınıfındaki BilgiYazdir() çalışır
        Console.WriteLine($" -> Otomobil Detayi: {KapiSayisi} kapili.");
    }
    
    // Otomobil sinafina ozgü Metot Overloading
    public void Hizlan(int artisMiktari)
    {
        Console.WriteLine($"{Marka} hizinı {artisMiktari} km/s artırdi.");
    }
    public void Hizlan(int artisMiktari, string surusModu)
    {

        Console.WriteLine($"{Marka}, '{surusModu}' modunda hazini {artisMiktari} km/s artirda.");
    }

}