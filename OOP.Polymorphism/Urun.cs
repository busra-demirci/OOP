using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public abstract class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Birim { get; set; }
        public int KdvOrani { get; set; }

        public abstract decimal KDVliFiyatHesapla(int kdvOrani);

        public virtual int StokMiktariSorgula()
        {
            return 400;
        }  
    }
}
