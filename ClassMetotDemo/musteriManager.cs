using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class musteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi! " + musteri.MusteriAdi+" "+musteri.MusteriSoyadi);
        }

        public void musteriGuncelle(string Hizmet, int Yasi)
        {
            Console.WriteLine("Müsteri Bilgisi Güncellendi! "+Hizmet+" "+Yasi);
        }

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi! " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi); ;
        }
       
    }
}
