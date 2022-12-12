using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplık_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kategori isimleri
            double toplamfiyat = 0;
            string secim;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***     Türkçe Kitaplar Kategorisi *** Yabancı Kitaplar Kategorisi       ***");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();


            //Kitap listesi
            Console.WriteLine("** 1-ÇalıKuşu: Reşat Nuri          *** 7-Tuna Kılavuzu: Jules Verne       **");
            Console.WriteLine();
            Console.WriteLine("** 2-Yaban: Yakup Kadri            *** 8-Bir Kuzay Macerası: Jack London  **");
            Console.WriteLine();
            Console.WriteLine("** 3-Sinekli Bakkal: Halide Edip   *** 9-Altıncı Koğuş: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("** 4-Tehlikeli Oyunlar: Oğuz Atay  *** 10-Kumarbaz: Dosyevski             **");
            Console.WriteLine();
            Console.WriteLine("** 5-Geçtiğim Günlerden: H.Yücel   *** 11-İki Şehrin Hikayesi: C.Dickens  **");
            Console.WriteLine();
            Console.WriteLine("** 6-Kürk Mantolu Madonna: S.Ali   *** 12-Vişne Bahçesi: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");

            //Kitap seçtirme işlemleri
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Kullanıcı Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstedğiniz İşlem Numarası: ");
           
            //İşlemler
            int islem;
            islem = Convert.ToInt16(Console.ReadLine());
            if(islem == 1)
            {
                Console.WriteLine();
                Console.Write("Lütfen Fiyatını Öğrenmek İstediğiniz Kitabın Numarasını Giriniz: ");
                int numara;
                numara = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
               
                switch(numara)
                {
                    case 1:
                        Console.WriteLine("ÇalıKuşu: Reşat Nuri = 40 TL ");
                        break;
                    case 2: 
                        Console.WriteLine("Yaban: Yakup Kadri = 36,40 TL");
                        break;
                    case 3:
                        Console.WriteLine("Sinekli Bakkal: Halide Edip = 67,50 TL");
                        break;
                    case 4:
                        Console.WriteLine("Tehlikeli Oyunlar: Oğuz Atay = 75 TL ");
                        break;
                    case 5:
                        Console.WriteLine("Geçtiğim Günlerden: H.Yücel = 45 TL");
                       break;
                    case 6:
                        Console.WriteLine("Kürk Mantolu Madonna: S.Ali = 12,35 TL");
                        break;
                    case 7:
                        Console.WriteLine("Tuna Kılavuzu: Jules Verne = 18 TL");
                        break;
                    case 8:
                        Console.WriteLine("Bir Kuzay Macerası: Jack London = 39,40 TL");
                        break;
                    case 9:
                        Console.WriteLine("Altıncı Koğuş: Anton Çehov = 10 TL");
                        break;
                    case 11:
                        Console.WriteLine("İki Şehrin Hikayesi: C.Dickens = 34 TL");
                        break;
                    case 12:
                        Console.WriteLine("Vişne Bahçesi: Anton Çehov = 16,75 TL");
                        break;
                    default: Console.WriteLine("Lütfen Geçerli Numara Giriniz!");
                        break;
                }
              


            }
            if (islem == 2)
            {
                Console.WriteLine("***** Yeni Kullanıcı Kaydı *****");
                Console.WriteLine();
                Console.Write("Adınız: ");
                string ad;
                ad = Console.ReadLine();
                
                Console.Write("Soyadınız: ");
                string soyad;
                soyad = Console.ReadLine();
           
                Console.Write("Okulunuz: ");
                string okul;
                okul = Console.ReadLine();

                //Metin belgesinde veritabanı
                string dosya = @"C:\Users\User\Desktop\KullanıcıVerileri.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Okulunuz: " +okul);
                Console.Write("Kayıt İşlemi Başarılı!");
                sw.Close();



            }
            if (islem == 3)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("******* Bugünün Kitabı: ÇalıKuşu **********");
                Console.WriteLine("*******************************************");

            }
            if (islem == 4)
            {
                Console.WriteLine();
                Console.WriteLine("***********************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\User\Desktop\KitapArşivi.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while(metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();


                }
                sr.Close();
                fs.Close();
                   
            }
            if (islem == 5)
            {
                for(int i=1; i<=50; i++)
                {
                    Console.WriteLine();
                    Console.Write("Almak İstediğiniz Kitap Numarasını Yazınız: ");
                    secim = Console.ReadLine();
                    if( secim == "1" )
                    {
                        toplamfiyat = toplamfiyat + 40;


                    }
                    else if (secim == "2")
                    {
                        toplamfiyat= toplamfiyat + 36.40;


                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 67.50;


                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 75;


                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 45;


                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 12.35;


                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 18;


                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 39.40;


                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 10;


                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 34;


                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 16.75;


                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir Kitap Numarası Giriniz!");
                        break;
                    }
                    Console.WriteLine("Toplam Tutar: " + toplamfiyat);


                }


            }
            if (islem == 6)
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1,100);
                while( sayi != tahmin)
                {
                    Console.Write(" Sayı Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if( tahmin > sayi)
                    {
                        Console.Write("Daha Küçük");


                    }
                    else if (tahmin == sayi)
                    {

                        Console.Write("Tebrikler Doğru Bildiniz");
                    }
                    else
                    {
                        Console.Write("Daha Büyük");
                    }

                }








            }
            





            Console.ReadKey();
        }
    }
}
