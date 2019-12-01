using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int TekerlekSayisi { get; set; }
        public decimal Fiyat { get; set; }

        public decimal KDVliFiyatHesapla(int kdvOrani)
        {
            return Fiyat + (Fiyat * kdvOrani) / 100;
        }
    }
}
