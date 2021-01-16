using System;

namespace Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Info = "Amasya elması";

            Product product2 = new Product();
            product2.Name = " Karpuz";
            product2.Price = 80;
            product2.Info = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };


            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + "    " + product.Info + "=" + product.Price + "    ");
            }

            Console.WriteLine("--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

        }
    }
}
