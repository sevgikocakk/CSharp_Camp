using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface onu implent eden classın referans nosunu tutabilir.
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Apply(vehicleCreditManager); tekli

            //applicationManager.Apply(houseCreditManager, databaseLoggerService);
            //applicationManager.Apply(new ArtisanCreditManager(), databaseLoggerService);
            //applicationManager.Apply(new ArtisanCreditManager(), new SmsLoggerService());

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new SmsLoggerService (), fileloggerService };
            applicationManager.Apply(artisanCreditManager, loggerServices);
            Console.WriteLine("--------------------------------");

            applicationManager.Apply(artisanCreditManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vehicleCreditManager};//çoklu
           // applicationManager.CreditPreInformation(credits);


        }
    }
}
