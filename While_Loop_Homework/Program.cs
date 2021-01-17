using System;

namespace While_Loop_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Döngüsü, belirlenen komut bloğunun verilen şart sağlandığı sürece dönmesini sağlayan döngü modelidir.
            //For'a nazaran daha ilkel ve sade bir döngüdür. 
            //While döngüsü programların ilk tasarlanmış döngüsüdür.
            //For döngüsünden farkı sadece şartı kontrol etmesidir.
            int sayi = 0;
            while (sayi < 10)
            {

                Console.WriteLine("Hello World!");
                sayi++;

            }
        }
    }
}
