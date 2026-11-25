namespace sinav
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" === ADIM 1: En Alt Sınıftan Parametresiz Nesne Oluşturma === ");                // [1]
            // Çalışna Sırası:
            // Elektrikli0tomobil() -> this( ... ) -> Elektrikli0tomobil(4 param) -> base( ... )
            // -> Otomobil(3 paran) -> base( ... ) -> Arac(2 param) çalışır ve govdeler yukarıdan aşağı tamamlanır.
            ElektrikliOtomobil varsayilanEv = new ElektrikliOtomobil();             // []
            Console.WriteLine();                // []

            Console.WriteLine(" === ADIM 2: Constructor Overloading Kullanarak Nesne Oluşturma === ");              // []
            // 2 parametreli ElektrikliOtomobil constructor'1 çağrılır
            Elektrikliotomobil ozelEv = new ElektrikliOtomobil("Tesla Model Y", 75);                // []
            Console.WriteLine();                // []

            Console.WriteLine(" === ADIM 3: Orta Seviye Sınıftan (Otomobil) Nesne Oluşturma === ");             // []
            Otomobil sedan = new Otomobil("Toyota Corolla", 2824, 4);               // []
            Console.WriteLine();                // []

            Console.WriteLine("m=# ADIM 4: Override ve Base Zincirleme Metot Çağrisı =");               // []
            // En alt sınıftan çağrılan BilgiYazdir(), base anahtar kelimesi sayesinde 3 sınıfın da bilgisini yazar
            varsayilanEv.BilgiYazdir();             // []
            Console.WriteLine();                // []

            Console.WriteLine(" === ADIM 5: Farklı Seviyelerdeki Metot Overloading Çağrıları === ");                // []
            // 1. Arac sanifindan miras alinan overloaded metot:
            ozelEv.BilgiYazdir("Filo aracı olarak tanımlandı.");                // []

            // 2. Otomobil sinifindan miras alanan overloaded metotlar:
            ozelEv.Hizlan(30);              // []
            ozelEv.Hizlan(50, "Sport");             // []

            // 3. ElektrikliOtomobil sinifina ait overloaded metotlar:
            ozelEv.SarjEt();                // []
            ozelEv.SarjEt(80, true);                // []

            Console.ReadLine();             // []
        }
    }
}