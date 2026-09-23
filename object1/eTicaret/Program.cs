using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cartValue = 0;
            string userType = "";
            string deliveryRegion = "";

            double deliveryFee = 0;
            double totalValue = 0;

            Console.WriteLine("Sepet Tutarini Giriniz:");
            double.TryParse(Console.ReadLine(), out cartValue);
            if (cartValue <= 0)
            {
                Console.WriteLine("Geçersiz sepet tutarı! Sipariş oluşturulamaz.");
                return;
            }
            Console.WriteLine("\n\nKullanici Tipini Seciniz \n1. Standart\n2. Premium\n");
            string userInput = Console.ReadLine();
            switch (Convert.ToInt32(userInput))
            {
                case 1:
                    userType = "Standart";
                    break;
                case 2:
                    userType = "Premium";
                    break;
                default:
                    Console.WriteLine("Gecerli deger girilmedi. Standart olarak devam edicek");
                    userType = " Standart";
                    break;
            }
            Console.WriteLine("\n\nTeslimat bolgesini seciniz \n1. Yurtici\n2. Yurtdisi");
            userInput = Console.ReadLine();
            switch (Convert.ToInt32(userInput))
            {
                case 1:
                    deliveryRegion = "Yurtici";
                    break;
                case 2:
                    deliveryRegion = "Yurtdisi";
                    break;
                default:
                    Console.WriteLine("Gecerli deger girilmedi. Yurtici olarak devam edicek");
                    userType = " Yurtici";
                    break;
            }

            if (deliveryRegion == "Yurtici" && userType == "Standart")
            {
                if (cartValue <= 500)
                {
                    deliveryFee = 45;
                }
            }
            if (deliveryRegion == "Yurtdisi")
            {
                if(userType == "Standart")
                {
                    if (cartValue <= 2000)
                    {
                        deliveryFee = 250;
                    }
                    else
                    {
                        deliveryFee = 100;
                    }
                }
                else
                {
                    deliveryFee = 350;
                }
            }




            totalValue = cartValue + deliveryFee;
            Console.WriteLine($"\n\nUyelik Tipi: {userType} \t Teslimat Bolgesi: {deliveryRegion}");
            Console.WriteLine($"\nSepet Tutari: {cartValue} \t Kargo Ucreti: {deliveryFee} \t Toplam Tutar: {totalValue}");
        }

    }
}
