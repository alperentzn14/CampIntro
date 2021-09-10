using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double bankaFaiz = 1.45;
            bool sistemeGirisYapmisMi = false;//true da olabilir
            double dolarDun = 7.55;
            double dolarBugun = 7.45;



            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs butonu göster");
            }
            else if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu göster");
            }
            else
            {
                Console.WriteLine("eşittir butonu göster");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("giris basarılı!!");
            }
            else
            {
                Console.WriteLine("Giris islemi Basarısız!!");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
