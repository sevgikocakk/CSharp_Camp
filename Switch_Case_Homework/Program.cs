using System;

namespace Switch_Case_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Switch Case bir akış kontrol mekanizmasıdır. 
             Switch case, kodun akışında belirli bir şarta göre yönlendirme yapmamızı 
             ( farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi yani tetiklememizi) sağlayan yapılardır.
             Switch Case yapılanması sadece bir değişkenin değerini eşitlik durumları kontrol ederken kullanılabilir. 
             Eşit mi yada eşit değil mi ona bakar.  " < , > , <= , >= " gibi durumları kontrol etmek istiyorsak orada switchi kullanamayız. 
             Öyle durumlarda if'i kullanmamız lazım. 
             Yani burada switch ve if'in farkı şudur if her şeyi ile birlikte şartı kontrol ederken switch sadece eşitlik durumuna bakar.
             Switch yapılanmasında amaç eşitlik durumuna göre belirli bir kod blogunu tetiklemektir. 
             case ile break arasına yazılan kodlar ilgili case'in doğrulanması sürecinde istenecek kodlardır.
             kontrol edilen değerin türü ne ise case bloklarında da aynı türde değerler kontrol edilmelidir.
             Switch yapılanmasında hiçbir case eşitlik durumunu sağlayamıyorsa bir default break arasındaki kodlar çalıştırılır. 
             default kalıbı zorunlu değildir.Herhangi bir case çalışmadı default da yok akış devam edecektir.*/

            string mevsim;
            Console.WriteLine("Bir mevsim adı giriniz:");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "İlkbahar":
                    Console.Write("Mart Nisan Mayıs");
                    break;
                case "Yaz":
                    Console.Write("Haziran Temmuz Ağustos");
                    break;
                case "Sonbahar":
                    Console.Write("EylüL Ekim Kasım");
                    break;
                case "Kış":
                    Console.Write("Aralık Ocak Şubat");
                    break;
                default:
                    Console.Write("Mevsim Adı Geçersiz..!");
                    break;
            }
    }
}
