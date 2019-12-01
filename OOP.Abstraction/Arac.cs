using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int TekerlekSayisi { get; set; }
        public decimal Fiyat { get; set; }

        //Abstract method
        //Miras verilen sınıflarda kullanılması zorunlu metodlar
        public abstract decimal FiyatHesapla();

        //Virtual methods
        //Polymorphism
        public virtual string HizYap()
        {
            return "hızınız 30 km/s";
        }
    }
}
