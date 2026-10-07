using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    /////////////
    /// 
    internal class Program
    {
        static void Main(string[] args)
        {
            int bolunen = 27;
            int bolen = 4;
            int bolum = BolmeIslemi(bolunen, bolen, out int kalann);

            Console.WriteLine("Bolum " + bolum);
            Console.WriteLine("Kalan " + kalann);

        }

        ///////
        /// Using "out" we can get multiple values from a method
        ///////
        static int BolmeIslemi(int bolunen, int bolen, out int kalan)
        {
            if (bolen == 0)
            {
                kalan = 0;
                return 0;
            }
            kalan = bolunen % bolen;
            return bolunen / bolen;
        }   
    }
}
