using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Selamlar!");
            //Console.Write("Merhaba Dünya!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Sıcak Başlangıçlar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region Değişkenler

            #region String Değişkenler
            //string name = "Numan";
            //Console.WriteLine(name);

            //string customerName = "Numan";
            //string customerSurname = "Karabuğa";
            //string customerPhone = "0555 555 55 55";
            //string customerEmail = "deneme@gmail.com";
            //string customerDistrict = "Mudanya";
            //string customerCity = "Bursa";

            //Console.WriteLine("**** Rezervasyon Yapan Müşteri Bilgileri ****\n");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon: " + customerPhone);
            //Console.WriteLine("E-Posta: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + " / " + customerCity);
            #endregion

            #region Int Değişkenler

            //int hamburgerMenuPrice = 400;
            //int cokeMenuPrice = 70;
            //int waterMenuPrice = 20;
            //int friesMenuPrice = 120;
            //int pizzaMenuPrice = 300;
            //int lemonadeMenuPrice = 90;

            //Console.WriteLine("*** Restoran Menü Fiyatı ***\n");
            //Console.WriteLine("-- Kola: " + cokeMenuPrice + " TL");
            //Console.WriteLine("-- Su: " + waterMenuPrice + " TL");
            //Console.WriteLine("-- Limonata: " + lemonadeMenuPrice + " TL");
            //Console.WriteLine("-- Hamburger: " + hamburgerMenuPrice + " TL");
            //Console.WriteLine("-- Pizza: " + pizzaMenuPrice + " TL");
            //Console.WriteLine("-- Patates Kızartması: " + friesMenuPrice + " TL");
            //Console.WriteLine();

            //int hamburgerOrderCount = 2;
            //int cokeOrderCount = 3;
            //int waterOrderCount = 1;
            //int friesOrderCount = 1;
            //int pizzaOrderCount = 0;
            //int lemonadeOrderCount = 2;

            //int totalHamburgerPrice = hamburgerMenuPrice * hamburgerOrderCount;
            //int totalCokePrice = cokeMenuPrice * cokeOrderCount;
            //int totalWaterPrice = waterMenuPrice * waterOrderCount;
            //int totalFriesPrice = friesMenuPrice * friesOrderCount;
            //int totalPizzaPrice = pizzaMenuPrice * pizzaOrderCount;
            //int totalLemonadePrice = lemonadeMenuPrice * lemonadeOrderCount;

            //int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            //Console.WriteLine("*********** FİŞ ***********\n");
            //Console.WriteLine("Hamburger ( *2 ) = " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola ( *3 ) = " + totalCokePrice + " TL");
            //Console.WriteLine("Su ( *1 ) = " + totalWaterPrice + " TL");
            //Console.WriteLine("Patates Kızartması ( *1 ) = " + totalFriesPrice + " TL");
            //Console.WriteLine("Limonata ( *2 ) = " + totalLemonadePrice + " TL");
            //Console.WriteLine("------------------------");

            //Console.WriteLine("Toplam Ücret: " + totalPrice + " TL");
            //Console.WriteLine("Afiyet Olsun..");


            #endregion

            #region Double Değişkenler

            //Console.WriteLine("**** Fiyat Listesi ****\n");

            //double applePrice = 15.55;
            //double bananaPrice = 12.30;
            //double orangePrice = 14.25;
            //double pearPrice = 18.90;

            //Console.WriteLine("-- Elma Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("-- Muz Fiyatı: " + bananaPrice + " TL");
            //Console.WriteLine("-- Portakal Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("-- Armut Fiyatı: " + pearPrice + " TL");
            //Console.WriteLine();

            //// Weights as kilos.
            //double appleWeight = 1.0;
            //double bananaWeight = 0.8;
            //double orangeWeight = 1.6;
            //double pearWeight = 1.8;

            //double totalApplePrice = applePrice * appleWeight;
            //double totalBananaPrice = bananaPrice * bananaWeight;
            //double totalOrangePrice = orangePrice * orangeWeight;
            //double totalPearPrice = pearPrice * pearWeight;

            //double totalPrice = totalApplePrice + totalBananaPrice + totalOrangePrice + totalPearPrice;

            //Console.WriteLine("- Meyve: Elma" + " - Birim Fiyat: " + applePrice + " TL" + " - Gramaj: " + appleWeight + " Kg" + " - Tutar: " + totalApplePrice);
            //Console.WriteLine("- Meyve: Muz" + " - Birim Fiyat: " + bananaPrice + " TL" + " - Gramaj: " + bananaWeight + " Kg" + " - Tutar: " + totalBananaPrice);
            //Console.WriteLine("- Meyve: Portakal" + " - Birim Fiyat: " + orangePrice + " TL" + " - Gramaj: " + orangeWeight + " Kg" + " - Tutar: " + totalOrangePrice);
            //Console.WriteLine("- Meyve: Armut" + " - Birim Fiyat: " + pearPrice + " TL" + " - Gramaj: " + pearWeight + " Kg" + " - Tutar: " + totalPearPrice);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");


            #endregion

            #region Char Değişkenler

            //char symbol = '#';
            //Console.WriteLine(symbol);

            #endregion

            #region Bool Değişkenler

            //bool isCustomerMember = true;
            //Console.WriteLine("Is the customer a member?  - " + isCustomerMember);


            #endregion

            #endregion

            #region Klavyeden Veri Girişi

            #region String Veri Girişi

            //Console.Write("Lütfen Adınızı Giriniz: ");
            //string passengerName = Console.ReadLine();
            //Console.Write("Lütfen Soyadınızı Giriniz: ");
            //string passengerSurname = Console.ReadLine();
            //Console.Write("Lütfen Yaşadığınız Şehri Giriniz: ");
            //string passengerCity = Console.ReadLine();

            //Console.WriteLine("\n***** Yolcu Bilgileri *****\n");
            //Console.WriteLine("Sayın " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Şehir: " + passengerCity);
            //Console.Write("Bilgilerinizi Onaylıyor Musunuz? ");
            //Console.ReadLine();

            #endregion

            #region Int Veri Girişi ve Dönüşümler

            //int shoePrice = 6000, TVPrice = 25000, computerPrice = 60000, phonePrice = 45000;

            //Console.Write("Lütfen aldığınız ayakkabı adetini giriniz: ");
            //int shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon adetini giriniz: ");
            //int TVCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar adetini giriniz: ");
            //int computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız telefon adetini giriniz: ");
            //int phoneCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoePrice * shoeCount) + (TVPrice * TVCount) + (computerPrice * computerCount) + (phonePrice * phoneCount);
            //Console.WriteLine("\nToplam Alışveriş Ücretiniz: " + totalPrice + " TL");

            #endregion

            #region Ondalıklı Veri Girişi

            //double exam1Score, exam2Score, exam3Score, averageScore;

            //Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1Score = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2Score = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3Score = double.Parse(Console.ReadLine());

            //averageScore = (exam1Score + exam2Score + exam3Score) / 3;

            //Console.WriteLine("\nSınav Ortalamanız: " + averageScore);

            #endregion

            #region Char Veri Girişi

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("\nSeçtiğiniz Cinsiyet: " + gender);

            #endregion

            #endregion




            Console.Read();
        }
    }
}