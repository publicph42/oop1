namespace Week06Main;

public class Student
{
    private int _not;

    public int Not
    {
        get { return _not; }
        set
        {
            if (value > 100)
            {
                Console.WriteLine("Not 100'den fazla girilemez");
            }
            else if (value < 0)
            {
                Console.WriteLine("Not 0'dan dusuk olamaz");
            }
            else
            {
                _not = value;
            }
        }
    }
    public string Ad { get; set; }
    public int Numara { get; set; }
    public string Bolum { get; set; } = "Default Bolum";
    public DateTime KayitTarihi { get; private set; }

    public Student(string ad, int numara)
        : this(ad, numara, "Bolumu belirsiz")
    {
        this.Ad = ad;
        this.Numara = numara;
        this.KayitTarihi = DateTime.Now;
    }

    public Student(string ad, int numara, string bolum)
    {
        this.Ad = ad;
        this.Numara = numara;
        this.Bolum = bolum;
    }

    public Student(string ad)
        : this(ad, 0)
    {
        this.Ad = ad;
    }
}
