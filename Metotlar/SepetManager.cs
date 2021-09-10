using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        /// <summary>
        /// ekleme metodu
        /// </summary>
        public void ekle(Urun urun)
        {
            /*urun.Id = 3;
            urun.Adi = "elma";
            urun.Fiyati=3.50;
            urun.Aciklama = "Amasya Elması";*/
            
            Console.WriteLine("Sepete Eklendi :"+urun.Adi);
        }
    }
}
