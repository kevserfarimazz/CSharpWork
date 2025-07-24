using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Çınar Öztürk");
            //    Console.WriteLine("Kenan Gül");
            //}
            //customerList();



            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = 3;
            //    Console.WriteLine(x + y + z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Kevser Farımaz");



            //void CustomerCard(string name, string SurName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + SurName);
            //}

            //CustomerCard("Kevser ", "Farımaz");
            //CustomerCard("Senem", "Öztürk");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametrileri Metotlar

            //void Sum(int number1,int number2, int number3)
            //{
            //    int result=number1+ number2+ number3;
            //    Console.WriteLine(result);
            //}

            //Sum(3, 4, 5);


            #endregion

            #region Geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();




            //string StudentCard()
            //{
            //    string name = "Buse";
            //    string surname = "Ay";

            //    return name+ " " + surname;

            //}
            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye değer döndüren  string Parametreli metotlar

            //string CountyCard(string countryName, string capital, string flagColor)

            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "-Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z= Console.ReadLine();


            //Console.WriteLine(CountyCard(x, y, z));

            //Console.WriteLine(CountyCard("Türkiye", "Ankara", "Kırmızı"));

            



            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(56, 78));
            //Console.WriteLine(Sum(34, 34));
            //Console.WriteLine(Sum(67,87));
            //Console.WriteLine(Sum(10, 80));





            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result= (exam1+ exam2+  exam3)/3;
                if (result >= 50)
                {
                    return  student + " isimli Öğrenci sınavı geçti " + "Ortalama: " +result ;
                }
                else
                {
                    return student + " isimli Öğrenci başarısız oldu" + "Ortalama: "+ result;

                }
            }

            Console.WriteLine(ExamResult("Ali", 23, 34, 90));
            Console.WriteLine(ExamResult("Banu", 67, 56, 90));

            

            #endregion
            Console.Read();
    }
}
}
