using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class Otomobil : Arac   
    {
        public int KapiSayisi { get; set; }
        public string YakitTuru { get; set; }
        public string BagajHacmi { get; set; }

        public override string ToString()
        {
            string aracBilgileri =
                "Marka: " + Marka + "\n" +
                "Model: " + Model + "\n" +
                "Renk: " + Renk + "\n" +
                "Tekerlek: " + TekerlekSayisi + "\n" +
                "Fiyat: " + Fiyat.ToString("C2") + "\n" + //c2 = fiyat currency2, virgülden sonra 2 hane ile fiyatı yazdır.
                "Kapı Sayısı: " + KapiSayisi + " kapi" + "\n" +
                "Yakıt Türü: " + YakitTuru + "\n" +
                "Bagaj Hacmi: " + BagajHacmi;

            return aracBilgileri;
        }
    }
}
