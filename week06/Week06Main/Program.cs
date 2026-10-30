namespace Week06Main;

internal class Program
{
    static void Main(string[] args)
    {
        // Araba a1 = new Araba();
        // a1.SetHiz(-20);
        // Console.WriteLine("Aracin hizi: " + a1.GetHiz());
        // a1.SetHiz(150);
        // Console.WriteLine("Aracin hizi: " + a1.GetHiz());
        // a1.SetHiz(500);
        // Console.WriteLine("Aracin hizi: " + a1.GetHiz());
        Araba a1 = new Araba();
        a1.Hiz = -20;
        Console.WriteLine("Aracin hizi: " + a1.Hiz);
        a1.Hiz = 160;
        Console.WriteLine("Aracin hizi: " + a1.Hiz);
        a1.Hiz = 500;
        Console.WriteLine("Aracin hizi: " + a1.Hiz);

        Console.WriteLine("\n\n\n");
        Student student1 = new Student("ogrenci 1", 01);
        student1.Not = 150;
        Console.WriteLine("Ogrencinin notu: " + student1.Not);
        student1.Not = 50;
        Console.WriteLine("Ogrencinin notu: " + student1.Not);
        student1.Not = -200;
        Console.WriteLine("Ogrencinin notu: " + student1.Not);

        Console.WriteLine("\n\n\n");

        Banka musteri = new Banka();
        Console.WriteLine("Bakiye: " + musteri.Bakiye);
        musteri.ParaCek(100);
        musteri.ParaYatir(90);
        musteri.ParaCek(100);
        musteri.ParaYatir(100);

        Console.WriteLine("\n\n\n");
        Student student2 = new Student("Ahmet ikinci", 02);
        Console.WriteLine($"Ogrenci adi: {student2.Ad}, Ogrenci no: {student2.Numara}");

        Console.WriteLine("\n\n\n");
        Student student3 = new Student("Ayse Ucuncu", 03, "Kaporta Muhendisligi");
        Console.WriteLine(
            $"Ogrenci adi: {student3.Ad}, Ogrenci no: {student3.Numara}, Ogrenci bolum: {student3.Numara}"
        );

        ///-------------- CONSTRUCTOR CHAINING --------------------///
        ConstructorChaining ch1 = new ConstructorChaining("to ", "ordu!\n");
    }
}
