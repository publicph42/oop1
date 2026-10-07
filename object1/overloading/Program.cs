using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYazdir("Ekrana yazi yazdir!");

            EkranaYazdir(2, 3);

            EkranaYazdir(5, 2, 9);

            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rnd.Next(0, 100));
            }

            EkranaYazdir(numbers);
        }

        //
        // OVERLOADING
        // We can write a method with the same name but different arguments
        // That way we can call the method with different data types
        //

        static void EkranaYazdir(string input)
        {
            Console.WriteLine(input);
        }
        static void EkranaYazdir(int number1, int number2
        {
            Console.WriteLine(number1 + number2);
        }
        static void EkranaYazdir(int number1, int number2, int number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }

        static void EkranaYazdir(List<int> numbers)
        {
            int result = 0;

            foreach(int number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
