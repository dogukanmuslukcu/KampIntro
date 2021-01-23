using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        //Method injection
        public void SetAppeal(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
            // basvuran bilgilerin degerlendirilmesi.
            //
            crediManager.Calculation();
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
                   
            }
         
        }
        public void CrediInformation(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculation();
            }
        }


    }
}
