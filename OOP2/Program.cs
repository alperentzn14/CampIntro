using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Gercek müsteri
            GercekMüsteri müsteri1 = new GercekMüsteri();
            müsteri1.MusteriNo = "12345";
            müsteri1.Adi = "Alperen";
            müsteri1.Soyadi = "Tüzün";
            müsteri1.TcNo = "123456";
            müsteri1.Id = 1;


            //TüzelMüsteri
            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MusteriNo = "1234567";
            müsteri2.Sirketdi = "TestSirket";
            müsteri2.VergiNo = "123123";

            //Gerçek Müsteri-Tüzel Müsteri 
            //tek bir Müsteri Class'ı kullanmak yanlış 2 çeşit müşteri vardır.
            ///SOLID-L


            Müsteri müsteri3 = new GercekMüsteri();
            Müsteri müsteri4 = new TüzelMüsteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(müsteri1);
            customerManager.Add(müsteri2);

        }
    }
}
