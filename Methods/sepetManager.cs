using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepetinize Eklendi" + urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string urunAcıklama, double urunFıyat)
        {
            Console.WriteLine("Tebrikler. Sepetinize Eklendi " + urunAdi);

        }
    }
}
