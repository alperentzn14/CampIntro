using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;

            Console.WriteLine("Sonuc :"+toplam);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int cıkar = sayi1 - sayi2;

            Console.WriteLine("Sonuc :"+cıkar);
        }
        public void Carp()
        {
            //int carp = sayi1 * sayi2;
            ///Console.WriteLine("Sonuc :"+carp);
        }
        public void Böl()
        {

        }
    }
}
