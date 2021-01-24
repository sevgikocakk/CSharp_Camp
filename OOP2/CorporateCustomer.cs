using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Customer sınıfı ebeveyndir yani base class türeten sınıf.
    //  CopporateCustomer sınıfıda çocuktur diyebiliriz yani derived class türeyen sınıf.
    class CorporateCustomer : Customer 
    {
        //Tüzel Müşteri
       
        public int TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
