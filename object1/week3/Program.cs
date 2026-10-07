using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnVeYirmiTopla();

            Topla(30, 20);

            Console.WriteLine(ToplaWithReturn(123, 2232));
        }

        //Parametre almayan ve return olmayan
        static void OnVeYirmiTopla()
        {
            int result = 10 + 20;
            Console.WriteLine(result);
        }

        //Parametre alan ve return olmayan
        static void Topla(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        //Parametre alan ve return olan
        static int ToplaWithReturn(int number1, int number2)
        {
            int result = number1 + number2;

            return result;
        }
    }
}
