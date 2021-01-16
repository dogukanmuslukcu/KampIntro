using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya giriş kursu";
            string kurs3 = "java";

            string[] kurslar = new string[] { kurs1, kurs2, kurs3 };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);
            }

        }
    }
}
