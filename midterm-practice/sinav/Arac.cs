namespace sinav;

public class Arac
{
    public string Marka {get;set;}
    public int UretimYili{get;set;}
    
    // Constructor 1: Parametresiz (Varsayilan)
    public Arac() : this("Bilinmiyor", DateTime.Now.Year) // Kendi icindeki diger constructor'a yonlendirme (this)
    {
        Console.WriteLine("[1] Arac -> Parametresiz Constructor çalışti.");
    }

    // Constructor 2: Tek parametreli (Overloading)
    public Arac(string marka) : this(marka, DateTime.Now.Year)

    {
        Console.WriteLine($"[1] Arac -> Tek Parametreli Constructor çalaşti. (Marka: {marka})");
    }

    // Constructor 3: İki parametreli Ana Constructor (Overloading)
    public Arac(string marka, int uretimYili)
    {
        this.Marka = marka; // Parametre ile sınıf alanını/ozelliğini ayırmak için 'this'
        this.UretimYili = uretimYili;
        Console.WriteLine($"[1] Arac -> İki Parametreli Ana Constructor çalişti. ({this.Marka} - {this.UretimYili})");
    }

    // Metot Overloading 1
    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Araç Bilgisi: {Marka} ({UretimYili})");
    }

    // Metot Overloading 2
    public void BilgiYazdir(string ekNot)
    {
        Console.WriteLine($"Araç Bilgisi: {Marka} ({UretimYili}) | Not: {ekNot}");
    }

}