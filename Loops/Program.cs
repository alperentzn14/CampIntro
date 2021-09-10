using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "kurs1";
            string kurs2 = "kurs2";
            string kurs3 = "kurs3";
            ///bu kullanım yanlış!!

            /////array=dizi

            string[] kurslar = new string[] { "kurs1", "kurs2", "kurs3","kurs4" };///dogrusu dizi kullanmak!!


         
            for (int i = 0; i < kurslar.Length; i++)///for döngüsü ile dizi dönmek
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü bitti");

            foreach (string kurs in kurslar)///foreach dizi temelli yapıları tek tek dönmeye yarar!
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
