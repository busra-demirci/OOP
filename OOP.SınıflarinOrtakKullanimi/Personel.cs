using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SınıflarinOrtakKullanimi
{
    public class Personel
    {
        public string AdSoyad { get; set; }
        public Departman Departman { get; set; }
        public Pozisyon Pozisyon { get; set; }

        public override string ToString()
        {
            string personelBilgileri =
                "Adı: " + AdSoyad + "\n" +
                "Departmanı: " + Departman.DepartmanAdi + "\n" +
                "Müdürü: " + Departman.Muduru + "\n" +
                "Pozisyon: " + Pozisyon.PozisyonAdi + "\n" +
                "Maaş: " + Pozisyon.Maas;

            return personelBilgileri;
        }
    }
}
