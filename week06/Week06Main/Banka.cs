namespace Week06Main;

public class Banka
{
    public double Bakiye { get; private set; }

    public void ParaYatir(double yatirilcakMiktar)
    {
        if (yatirilcakMiktar > 0)
            this.Bakiye += yatirilcakMiktar;
        Console.WriteLine("Bakiye: " + this.Bakiye);
    }

    public void ParaCek(double cekilcekMiktar)
    {
        if (cekilcekMiktar > 0)
            this.Bakiye -= cekilcekMiktar;
        Console.WriteLine("Bakiye: " + this.Bakiye);
    }
}
