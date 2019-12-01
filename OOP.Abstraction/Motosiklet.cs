using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public class Motosiklet : Arac
    {
        public int MotorHacmi { get; set; }

        public override decimal FiyatHesapla()
        {
            return Fiyat * 1.10M;
        }

        public override string HizYap()
        {
            return "hızınız 220 km/s";
        }
    }
}
