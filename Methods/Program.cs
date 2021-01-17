using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 9;
            urun1.UrunAciklama = "Amasya Elması.";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyati = 80;
            urun2.UrunAciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.UrunAdi);
                Console.WriteLine(Urun.UrunFiyati);
                Console.WriteLine(Urun.UrunAciklama);
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("**************METODLAR***********");
            //Instance-örnek
            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Taze Armut", 9);
            sepetManager.Ekle2("Çilek", "Dondurulmuş Çilek", 18);
        }
    }
}
