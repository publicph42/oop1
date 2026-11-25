namespace Week12Main;

public class Program
{
    static void Main(string[] args)
    {
        List<Sekil> sekiller = new List<Sekil>
        {
            new Kare(ConsoleColor.Magenta),
            new Daire(),
            new Ucgen(ConsoleColor.DarkRed)
        };
        foreach(Sekil s in sekiller)
        {
            s.Ciz();
            s.BilgiYazdir();
        }
    }
}
