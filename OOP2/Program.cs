using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndiviualCustomer customer1 = new IndiviualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = 01;
            customer1.Name = "Sevgi";
            customer1.Surname = "Koçak";
            customer1.TcNo = 1234567910;
            


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = 02;
            customer2.CompanyName = "Kodlama i.o";
            customer2.TaxNumber = 123456731;

            //Customer customer3 = new IndiviualCustomer();
            //Customer customer4 = new CorporateCustomer();
            //Burada olan şey base classı ile direkt olarak türeyen sınıflar için instance oluşturabildiğimiz.
            //Burada customer hem bireysel müşterinin referansını tutabiliyor hemde tüzel müşterinin referansını tutabiliyor.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
           





        }
    }
}
