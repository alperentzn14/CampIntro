using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    /// <summary>
    /// erişim bildirgecimiz public
    /// </summary>
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati {get; set; }
        public string Aciklama { get; set; }
    }
}
