using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();*/


            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            ///Kredilerimiz

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogglerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
   

        }
    }
}
