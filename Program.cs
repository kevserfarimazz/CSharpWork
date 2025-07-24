using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları


            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("******* Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("******* Yemek Kategorileri*****");
            #endregion

            #region Değişkenler

            //string
            //Değişken_Türü değişken_Adı;

            //string name;
            //name = "Kevser";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Kenan";
            //customerSurname = "Çınar";
            //customerPhone = "+90 123 456 45 45";
            //customerEmail = "eneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı***");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerSurname + " " + customerSurname);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            //Console.WriteLine();

            //customerName = "Ayşe";
            //customerSurname = "Kara";
            //customerPhone = "+90 234 567 78 89";
            //customerEmail = "jasxbkjsöldsşck@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerSurname + " " + customerSurname);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");





            #endregion

            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int HamburgerPrice = 300;
            int CokePrice = 35;
            int WaterPrice = 10;
            int FriesPrice = 50;
            int PizzaPrice = 50;
            int LemonadePrice = 20;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + HamburgerPrice + "TL");
            Console.WriteLine("-----Pizza: " + PizzaPrice + "TL");
            Console.WriteLine("-----Water: " + WaterPrice + "TL");
            Console.WriteLine("-----Fries: "+ FriesPrice+ "TL");
            Console.WriteLine("-----Pizza :" + PizzaPrice + "Tl");
            Console.WriteLine("-----Lemonede :" + LemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int CokeCount;
            int WaterCount;
            int FriesCount;
            int LemonadeCount;

            int totalhamburgerPrice;
            int totalPizzaPrice;
            int totalCokePrice;
            int totalWaterPrice;  
            int totalFriesPrice;
            int totalLemonadePrice;
            Console.WriteLine();


            hamburgerCount = 3;
            pizzaCount = 4;
            CokeCount = 1;
            WaterCount = 0;
            FriesCount = 3;
            LemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * HamburgerPrice;
            totalPizzaPrice= pizzaCount* PizzaPrice;
            totalCokePrice = CokeCount * CokePrice;
            totalWaterPrice = WaterPrice* WaterCount;
            totalFriesPrice = FriesPrice* WaterCount;
            totalLemonadePrice= LemonadePrice* LemonadeCount;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı:  " +totalhamburgerPrice + "TL");
            Console.WriteLine("coke Tutarı:  " +totalCokePrice + "TL");
            Console.WriteLine("water Tutarı:  " +totalWaterPrice + "TL");
            Console.WriteLine("fries Tutarı:  " +totalFriesPrice + "TL");
            Console.WriteLine("lemonade Tutarı:  " +totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFriesPrice + totalhamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");



            #endregion

            Console.Read();

        }
    }
}


//Yazdırma Komutları