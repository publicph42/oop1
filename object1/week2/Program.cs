using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] dizi1 = { 1, 2, 3 };
            int[] dizi2 = dizi1;
            dizi2[0] = 99;

            Console.WriteLine($"a {a}, dizi1[0]: {dizi1[0]}");

            // value data types are created on the stack
            // (int, char, bool, float...) predefined types (enum, struct) user defined types

            // reference data types are created on the heap
            // (object, string) predefined types (class, interface, delegate) user defined types

            //////////////////////////////////////////
            // explanation of the exercise:
            // int datas are created on the stack. we made "a" and set it to 10. 
            // then we made "b" and set it to "a". then we set "b" to 20
            // when we printed both values and they came out as expected.
            // but arrays doesn't perform as intuite as this
            // we made "dizi1" and set 3 values of to the array
            // we made "dizi2" and set that to "dizi1"
            // then we set "dizi2[0]" to 99
            // and when we printed "dizi1[0]" it prints 99. 
            // even though we didn't change the values of "dizi1" directly
            // because when we made "dizi1" the values are created on the heap
            // and "dizi1" is just a pointer on the stack
            // and when we made "dizi2" it doesn't copy the values to another address on the heap
            // it just copies the same pointer that "dizi1" had 
            // then we printed "dizi1[0]" and because the pointer is still pointing to the same adrress
            // it showed that value
            //////////////////////////////////////////////


            /// data on the heap is freed with garbage collection (if we are using C# which has GC)
            /// data on the stack is freed autamatically(?) when it stops being used. 
            /// I think it lives as much as the method that is using it. I'm not sure about that right now


            /////////////////////////////////////////
            
            string c = "123";
            int d = Convert.ToInt32(c); // Converts makes the null value 0
            Console.WriteLine(d);
            int e = int.Parse(c); // Can't convert null. It will throw an compiler error.
            Console.WriteLine(c);

            /////////////////////////////////////////


            Console.WriteLine("\n\n\nYasinizi Giriniz!");
            if (int.TryParse(Console.ReadLine(), out int yas))
            {
                Console.WriteLine("Yasiniz: " + yas);
            }
            else
            { 
                Console.WriteLine("Rakam girin!");
            }

            /////////////////////////////////////////

            char not = 'B';
            string outputText = "Default Text";
            switch (char.ToUpper(not))
            {
                case 'A':
                    outputText = "Efsane";
                    break;
                case 'B':
                    outputText = "Idare eder";
                    break;
                case 'C':
                    outputText = "Cok Kotu";
                    break;
                default:
                    break;
            }
            Console.WriteLine(outputText);


                

            


        }
    }
}
