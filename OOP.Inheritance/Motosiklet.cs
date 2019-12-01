using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class Motosiklet : Arac
    {
        public int MotorHacmi { get; set; }

        public override string ToString()
        {
            string motosikletBilgileri =
                "Marka: " + Marka + "\n" +
                "Model: " + Model + "\n" +
                "Renk: " + Renk + "\n" +
                "Tekerlek: " + TekerlekSayisi + "\n" +
                "Fiyat: " + Fiyat.ToString("C2") + "\n" +
                "Motor Hacmi: " + MotorHacmi + " cc";

            return motosikletBilgileri;
        }
    }
}
