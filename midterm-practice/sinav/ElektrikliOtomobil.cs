namespace sinav;

public class ElektrikliOtomobil : Otomobil
{
    public int BataryaKapasitesikWh { get; set; }


    // Constructor 1: Parametresiz -> Kendi içindeki 4 parametreli constructor'a gider (this)
    public ElektrikliOtomobil() : this("Togg T10X", 2026, 5, 88)
    {

        Console.WriteLine("[3] ElektrikliOtomobil -> Parametresiz Constructor çalıştı.");
    }

    // Constructor 2: Sadece marka ve batarya alan Overloading -> Kendi içindeki tam constructor'a gider (this)
    public ElektrikliOtomobil(string marka, int bataryaKapasitesi) : this(marka, 2026, 4, bataryaKapasitesi)

    {

        Console.WriteLine("[3] ElektrikliOtomobil -> 2 Parametreli Constructor çalıştı.");
    }

    // Constructor 3: Tüm parametreleri alan Ana Constructor -> Otomobil sınifina gönderir (base)
    public ElektrikliOtomobil(string marka, int uretimYili, int kapiSayisi, int bataryaKapasitesi)
    : base(marka, uretimYili, kapiSayisi)
    {
        this.BataryaKapasitesikWh = bataryaKapasitesi;
        Console.WriteLine($"[3] ElektrikliOtomobil -> 4 Parametreli Ana Constructor galişti. (Batarya: {this.BataryaKapasitesikWh} kwh)");
    }
    public override void BilgiYazdir()
    {

        base.BilgiYazdir(); // Otomobil sinzfindaki BilgiYazdir() metodunu tetikler
        Console.WriteLine($" -> Elektrikli Sistem: [Bataryakapasitesikwh] kwh batarya kapasitesi.");
    }

    // Metot Overloading (Şarj etme senaryosu)
    public void SarjEt()
    {
        Console.WriteLine($"{Marka} standart AC priz ile şarj ediliyor.");
    }

    public void SarjEt(int hedefYuzde, bool hizliSarjMi)
    {
        string tip = hizliSarjMi ? "DC Hizla Şarj" : "AC Standart Şarj";
        Console.WriteLine($"{Marka} istasyonunda %{hedefYuzde} doluluk hedefine kadar sarj ediliyor");
    }
}