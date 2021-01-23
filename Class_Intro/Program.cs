using System;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("*****************Kurs Programı************************\n");

            Ogrenci YeniOgrenci = new Ogrenci();
            YeniOgrenci.Adi = "Mehmet";
            YeniOgrenci.Soyadi = "Koçak";
            YeniOgrenci.KayitNo = 12345;
            YeniOgrenci.KursAdi = "C#";

            Ogrenci YeniOgrenci2 = new Ogrenci();
            YeniOgrenci2.Adi = "Sevgi";
            YeniOgrenci2.Soyadi = "Aslan";
            YeniOgrenci2.KayitNo = 54321;
            YeniOgrenci2.KursAdi = "Java";

            Ogrenci YeniOgrenci3 = new Ogrenci();
            YeniOgrenci3.Adi = "Yasin";
            YeniOgrenci3.Soyadi = "Kargan";
            YeniOgrenci3.KayitNo = 17839;
            YeniOgrenci3.KursAdi = "Python";

            //Console.WriteLine(YeniOgrenci.KursAdi +":" + YeniOgrenci.KayitNo );

            Ogrenci[] Egitimler = new Ogrenci[] { YeniOgrenci, YeniOgrenci2, YeniOgrenci3 };


            foreach (var Ogrenci in Egitimler)
            {
                Console.WriteLine(Ogrenci.Adi + ":" + Ogrenci.Soyadi);
                Console.WriteLine(Ogrenci.KayitNo + ":" + Ogrenci.KursAdi);
            }

        }
        class Ogrenci
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int KayitNo { get; set; }
            public string KursAdi { get; set; }




        }
    }
 }

