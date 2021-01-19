using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************MÜŞTERİ TAKİP*******************");

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1121;
            musteri1.Hizmet = "Banka Kartı";
            musteri1.MusteriAdi = "Sevgi";
            musteri1.MusteriSoyadi = "Aslan";
            musteri1.MusteriYasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2212;
            musteri2.Hizmet = "Kredi Kartı";
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "Kargan";
            musteri2.MusteriYasi = 35;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3323;
            musteri3.Hizmet = "Bireysel Emeklilik";
            musteri3.MusteriAdi = "Nalan";
            musteri3.MusteriSoyadi = "Yağız";
            musteri3.MusteriYasi = 32;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine("ID :"+Musteri.MusteriId +" | "+ Musteri.Hizmet);
                Console.WriteLine(Musteri.MusteriAdi + " " + Musteri.MusteriSoyadi + " | " + Musteri.MusteriYasi);
                Console.WriteLine("\n----------------------------------");
            }

            Console.WriteLine("\n***********Musteri Ekleme*************\n");
            musteriManager musteriManager = new musteriManager();
            musteriManager.musteriEkle(musteri1);
            musteriManager.musteriEkle(musteri2);
            musteriManager.musteriEkle(musteri3);

            Console.WriteLine("\n***********Musteri Güncelle*************\n");
            musteriManager musteriManager1 = new musteriManager();
            musteriManager1.musteriGuncelle("ID:" +1121 +"| Bireysel Emeklilik | ",22);
            musteriManager1.musteriGuncelle("ID:" + 2212 + "| Banka Kartı | ", 35);
            musteriManager1.musteriGuncelle("ID:" + 3323 + "| Yeni Hesap Açma | ", 33);

            Console.WriteLine("\n***********Musteri Silme*************\n");
            musteriManager musteriManager2 = new musteriManager();
            musteriManager2.musteriSil(musteri1);
            musteriManager2.musteriSil(musteri2);
            musteriManager2.musteriSil(musteri3);


        }
    }
}
