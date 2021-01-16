using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.egitmen = "engin demirog";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.egitmen = "doğukan muslukçu";
            kurs2.IzlenmeOranı = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.egitmen = "Berkay bilgin";
            kurs3.IzlenmeOranı = 80;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach ( Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+"    "+kurs.egitmen+"    "+kurs.IzlenmeOranı);
            }


          // Console.WriteLine("Hello World!");
        }
    }

    class  Kurs
    {
        public string KursAdi { get; set; }

         public string egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}
