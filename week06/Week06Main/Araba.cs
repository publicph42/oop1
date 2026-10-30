namespace Week06Main;

public class Araba
{
    // private int _hiz;
    //
    // public int GetHiz()
    // {
    //     return _hiz;
    // }
    //
    // public void SetHiz(int value)
    // {
    //     if (value < 0)
    //     {
    //         Console.WriteLine("Hata: Hiz 0'dan kucuk olamaz");
    //     }
    //     else if (value > 260)
    //     {
    //         Console.WriteLine("Hata: Kadran max degeri 260");
    //     }
    //     else
    //     {
    //         _hiz = value;
    //     }
    // }
    //
    /////////////// The above example of how we would do
    /////////////// it in java and the below is C# standard
    private int _hiz;

    public int Hiz
    {
        get { return _hiz; }
        set
        {
            if (value >= 0 && value <= 260)
            {
                _hiz = value;
            }
            else
            {
                Console.WriteLine("Gecersiz bir deger atadiniz");
            }
        }
    }
    private string _sasiNo = "TR-2026-42042";

    public string SasiNo
    {
        get { return _sasiNo; }
        set { }
    }

    // Derleyici arka planda gizli bir backing field olusturur.
    public string Marka { get; set; } = "Default Marka";
    public string Model { get; private set; } = "Default Model"; // we made the set private, that makes the valule read only
}
