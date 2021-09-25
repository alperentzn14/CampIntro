using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method İnjection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran Bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //birden fazla kredinin hesabını yapmak için list Kullanırız.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
