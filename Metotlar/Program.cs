using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "elma";
            urun1.Fiyati=3.25;
            urun1.Aciklama = "Amasya Elması";
            ///Console.WriteLine(urun1.Id+" "+urun1.Adi+" "+urun1.Fiyati+" "+urun1.Aciklama);


         

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "karpuz";
            urun2.Fiyati = 5.50;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            ///Console.WriteLine(urun2.Id + " " + urun2.Adi + " " + urun2.Fiyati + " " + urun2.Aciklama);

            Urun[] Urunler = new Urun[] {urun1,urun2 };

            foreach (var Urun in Urunler)
            {
                Console.WriteLine("Ürün Adı:"+Urun.Adi + "Ürün Fiyatı:" + Urun.Fiyati + "Acıklama:" + Urun.Fiyati + ":" + Urun.Aciklama);
            }


            Console.WriteLine("-----------METOTLAR------------");
            /////instance oluşturuyoruz ve metodu cagırıyoruz.
            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);



        }
    }
}
