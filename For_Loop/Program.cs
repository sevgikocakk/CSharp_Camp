using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü tekrarlanması istenilen kod satırının ya da kod bloğunun, belirtilen sayı kadar, 
            //belirlenen şart sağlanana kadar ve istenen artış ya da azalış sayısı kadar tekrarlanmasını sağlayan döngü yapısıdır.
            /*for (sayac ; kosul ; artış)
             {
	                kod blogu;   
            } */
            /*For Döngüsü şöyle çalışır…
            Döngü değişkeni tanımlanır ve ilk ataması yapılır
            Koşul test edilir ve koşul doğru ise for-kod bloğunun içine girilir.
            Komutlar çalıştırılır.
            Komut çalıştıktan sonra döngü değişkenini değiştirdiğimiz alana gelinir ve amaca yönelik arttırılır veya azaltılır.
            Tekrar koşul sorgulanır. Eğer koşul doğru ise tekrar komutlar çalıştırılır.
            Koşul yanlış ise döngü biter.*/

            string[] kurslar = new string[] { "Ruby", "Java", "Python", "C#" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
        }
    }
}
