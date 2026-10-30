namespace Week05Main;

internal class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = new Araba();
        araba1.marka = "Toyota";
        araba1.model = "Corolla";
        araba1.hiz = 60;

        Araba araba2 = new Araba();
        araba2.marka = "BMW";
        araba2.model = "320i";
        araba2.hiz = 90;

        araba1.Hizlan(20);
        araba2.FrenYap(5);
        araba1.Dur();
        araba2.Dur();

        // On the example below we make a new Araba object
        // We make that point to a1
        // then we make a2 point to a1
        // then we change a2.marka to ford and when we print a1.marka we get ford.
        // even though we didn't change a1 directly they were pointing to the same object
        // that's why it worked like this
        Araba a1 = new Araba();
        a1.marka = "Volvo";

        Araba a2 = a1;
        a2.marka = "Ford";

        Console.WriteLine($"a1 araba markasi: {a1.marka}");
    }
}

internal class Araba
{
    public string marka = "";
    public string model = "";
    public int hiz;

    public void Hizlan(int artisMiktari)
    {
        hiz += artisMiktari;
        Console.WriteLine($"{marka} hizlandi. Guncel hiz: {hiz}km/s");
    }

    public void FrenYap(int yavaslamaMiktari)
    {
        hiz -= yavaslamaMiktari;
        Console.WriteLine(
            $"{marka} araba {yavaslamaMiktari} kadar yavasladi. Guncel hiz: {hiz}km/s"
        );
    }

    public void Dur()
    {
        hiz = 0;
        Console.WriteLine($"{marka} araba tamamen durdu.");
    }
}
