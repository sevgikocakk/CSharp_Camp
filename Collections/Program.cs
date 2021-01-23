using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Kerem","Halil","Kerem"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            //.NET Framework, verileri depolamak ve işlemek için kullanışlı genel toplama sınıfları(generic collection classes) sağlar.
            //Bu sınıflar System.Collections.Generic ad alanında(namespace) bulunur.
            //List sık kullanılan koleksiyon sınıflarından biridir:
            //List sınıfı, bir takım kullanışlı metotlar içerir:
            //Add, List’e bir öğe ekler.
            //Clear, List’deki tüm öğeleri kaldırır.
            //Contains, belirtilen öğenin List’te bulunup bulunmadığını belirler.
            //Count, List’deki öğe sayısını döndürür.
            //Insert, belirtilen dizinde bir öğe ekler.
            //Reverse, List’deki öğelerin sırasını ters çevirir.


            List<string> isimler2 = new List<string>{"Engin","Kerem","Halil","Kerem"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //isimler2.Remove("Kerem");
            //Console.WriteLine(isimler2);


            // Öyleyse diziler(array) yerine List‘leri neden kullanmalıyım?
            //Çünkü, dizilerden farklı olarak, bir koleksiyonda birlikte çalıştığınız nesnelerin grubu büyüyebilir ve dinamik olarak daralabilir.
















        }
    }
}
