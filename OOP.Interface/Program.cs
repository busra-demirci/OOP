using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel
            {
                AdSoyad = "Bülent Başyurt",
                Pozisyon = Enums.Pozisyon.YazilimGelistirici
            };

            personel.Maas = personel.MaasHesapla(personel.Pozisyon);
            
        }
    }
}
