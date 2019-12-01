using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Kola : Icecek
    {
        public override decimal KDVliFiyatHesapla(int kdvOrani)
        {
            return Fiyat + (Fiyat * kdvOrani / 100);
        }

        public override int StokMiktariSorgula()
        {
            return 400;
        }
    }
}
