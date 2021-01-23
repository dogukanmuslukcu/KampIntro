using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager requirementCrediManager = new RequirementCrediManager();
            ICrediManager vehichleCrediManager = new VehichleCrediManager();
            ICrediManager morgıcCrediManager = new MorgıcCrediManager();

            AppealManager appealManager = new AppealManager();
            appealManager.SetAppeal(requirementCrediManager,new List<ILoggerService> (){ 
                new DatabaseLoggerService(),  new FileLoggerService()});

            List<ICrediManager> credits = new List<ICrediManager>() {requirementCrediManager,morgıcCrediManager };

           // appealManager.CrediInformation(credits);


        }
    }
}
