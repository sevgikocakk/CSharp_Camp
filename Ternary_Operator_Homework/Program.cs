using System;

namespace Ternary_Operator_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary operatörü şarta bağlı değer döndüren bir operatördür. Bir karar yapısı diyebiliriz.
            //İf - else benzer ama ternary operatörü tek satır veya satır bazlı şart kontrolü yaparak değer döndürür. 
            //Dönecek değerler aynı tür olmalıdır yani biri int biri string olamaz. Farklı değerde aynı tür veri dönmeli.
            //koşul? doğru ise burası : yanlış ise burası çalışsın şeklinde bir kalıbı vardır.

            bool medeniHal = true;
            string sonuc = medeniHal == true ? "Evlilere Kampanya.." : "Bekarlara Kampanya";
            Console.WriteLine(sonuc);
        }
    }
}
