using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Swap values using their refs
            int x = 10;
            int y = 20;
            Console.WriteLine($"Onceki x: {x}\nOnceki y: {y}\n");
            SwapValues(ref x, ref y);
            Console.WriteLine($"Sonraki x: {x}\nSonraki y: {y}");

        }
        //This is simple example to swap values using their ref
        static void SwapValues(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
        }



    }
}
