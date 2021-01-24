using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // method injection
        public void Apply(ICreditManager creditManager ,  List<ILoggerService> loggerServices)//ILoggerService loggerService tekli
        {
            creditManager.DoSomething();//tekli
            //loggerService.log(); tekli
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
        }

        public void CreditPreInformation(List<ICreditManager> credits)//coklu
        {
            foreach (var credit in credits)
            {
                credit.DoSomething();
            }
        }
    }
}
