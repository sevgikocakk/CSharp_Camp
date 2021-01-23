using System;

namespace Class_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************KİTAPLIK LİSTESİ************************\n");

            Kitaplık Kitap1 = new Kitaplık();
            Kitap1.KitapAdi = "Otostopçunun Galaksi Rehberi";
            Kitap1.YazarAdi = "Douglas Adams";
            Kitap1.YayınEvi = "Alfa";
            Kitap1.SayfaSayısı = 868;

            Kitaplık Kitap2 = new Kitaplık();
            Kitap2.KitapAdi = "Başarı Bilimi";
            Kitap2.YazarAdi = "Mümin Sekman";
            Kitap2.YayınEvi = "Alfa";
            Kitap2.SayfaSayısı = 288;

            Kitaplık Kitap3 = new Kitaplık();
            Kitap3.KitapAdi = "Frankfurt Yolcusu";
            Kitap3.YazarAdi = "Agatha Christie";
            Kitap3.YayınEvi = "Altın Kitap";
            Kitap3.SayfaSayısı = 263;

            Kitaplık[] Kitaplar = new Kitaplık[] { Kitap1, Kitap2, Kitap3 };

            for (int i = 0; i < Kitaplar.Length; i++)
            {
                Console.WriteLine(Kitaplar[i].KitapAdi + " : " + Kitaplar[i].YazarAdi);
                Console.WriteLine(Kitaplar[i].YayınEvi + " : " + Kitaplar[i].SayfaSayısı);
            }

            Console.WriteLine("***************************************************");

            foreach (var Kitaplık in Kitaplar)
            {
                Console.WriteLine(Kitaplık.KitapAdi + " : " + Kitaplık.YazarAdi);
                Console.WriteLine(Kitaplık.YayınEvi + " : " + Kitaplık.SayfaSayısı);
            }

            Console.WriteLine("***************************************************");

            int z = 0;
            while (z < Kitaplar.Length)
            {
                Console.WriteLine(Kitaplar[z].KitapAdi + " : " + Kitaplar[z].YazarAdi);
                Console.WriteLine(Kitaplar[z].YayınEvi + " : " + Kitaplar[z].SayfaSayısı);
                z++;
            }





        }
        class Kitaplık
        {
            public string KitapAdi { get; set; }
            public string YazarAdi { get; set; }
            public string YayınEvi { get; set; }
            public int SayfaSayısı { get; set; }



        }

    }
}
