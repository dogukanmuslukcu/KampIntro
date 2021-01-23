using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequirementCrediManager : ICrediManager
    {
        public void Another()
        {
            throw new NotImplementedException();
        }

        public void Calculation()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");

        }
    }
}
