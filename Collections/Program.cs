using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Alperen", "Ali", "Murat", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////normal dizi kullanımı bu şekilde gerçek hayatta ise COLLECTİON KULLANILIR!.

            ///collection kullanımı bu şekilde.
            List<string> isimler2 = new List<string> { "Alperen", "Ali", "Murat", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ahmet");///diziye eleman ekliyoruzz..
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
