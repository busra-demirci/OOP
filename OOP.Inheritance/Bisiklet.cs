using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    class Bisiklet: Arac
    {
        public bool SelesiVarMi { get; set; }
        public int VitesSayisi { get; set; }

        public override string ToString()
        {
            string bisikletBilgileri =
                "Marka: " + Marka + "\n" +
                "Model: " + Model + "\n" +
                "Renk: " + Renk + "\n" +
                "Tekerlek: " + TekerlekSayisi + "\n" +
                "Fiyat: " + Fiyat.ToString("C2") + "\n" +
                "Selesi Var Mı?: " + SelesiVarMi + "\n" +
                "Vites Sayısı: " + VitesSayisi + " vites";

            return bisikletBilgileri;
        }
    }
}
