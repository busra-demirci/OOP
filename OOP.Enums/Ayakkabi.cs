using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Enums
{
    public class Ayakkabi
    {
        public int Numara { get; set; }
        public Enums.Renk Renk { get; set; }
        public Enums.Tur Tur { get; set; }

        public override string ToString()
        {
            string ayakkabiDetayi =
                "Numara: " + Numara + "\n" +
                "Renk: " + Renk.ToString() + "\n" +
                "Türü: " + Tur.ToString();

            return ayakkabiDetayi;
        }
    }
}
