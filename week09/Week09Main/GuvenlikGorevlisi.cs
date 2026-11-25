namespace Week09Main;

public class GuvenlikGorevlisi : Calisanlar 
{
    public GuvenlikGorevlisi(string adSoyad, decimal maas) : base (adSoyad, maas)
    {
        
    }
   public override void MesaiBaslat()
    {
        base.MesaiBaslat();
        Console.WriteLine($"Nobet defteri imzalandi");
    } 
}