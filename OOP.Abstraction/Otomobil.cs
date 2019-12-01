using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public class Otomobil : Arac
    {
        public int KapiSayisi { get; set; }
        public string YakitTuru { get; set; }
        public string BagajHacmi { get; set; }

        public override decimal FiyatHesapla()
        {
            return Fiyat * 1.05M;
        }

        public override string HizYap()
        {
            return "hızınız 120 km/s.";
        }
    }
}
