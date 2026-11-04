namespace Week09Main;
internal class Program()
{
    static void Main(string[] args)
    {
    //     Yazilimci yaz2 = new Yazilimci();
        
    //     yaz2.ID = 1;
    //     yaz2.AdSoyad = "Furkan Akin";
    //     yaz2.BilgiVer();

    //     yaz2.BildigiDiller = "C#, PHP ve geri kalan her sey";
    //     yaz2.KodYaz();

    //     yaz2.PrimEkle(32174824);
    // The above initilazition won't work because our updated class requires parameters to create the object.


        Yazilimci yaz2 = new Yazilimci("Furkan", 343939843, "C#");
    }
}