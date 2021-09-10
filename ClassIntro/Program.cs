using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "yazılım geliştirme kampı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 107951;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java+react geliştirme kampı";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.İzlenmeOrani = 135000;

            Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.İzlenmeOrani);


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
       
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
