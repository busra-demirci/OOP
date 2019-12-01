using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance
            Kola kola = new Kola();
            kola.Id = 555;
            kola.UrunAdi = "Coca-Cola";
            kola.Fiyat = 5;
            kola.Birim = "Koli";
            kola.SiselemeTuru = "Plastik Şişe";
            kola.SiseHacmi = "1 LT";

            //Class initialization
            Kola kola1 = new Kola
            {
                Id = 555,
                UrunAdi = "Coca-Cola",
                Fiyat = 5,
                Birim = "Koli",
                SiselemeTuru = "Plastik Şişe",
                SiseHacmi = "1 LT"
            };

            decimal kdvliFiyat = kola1.KDVliFiyatHesapla(5);
            int kalanStok = kola1.StokMiktariSorgula();

            Console.WriteLine("Kola satış fiyatı: " + kdvliFiyat.ToString("C2"));
            Console.WriteLine("Kalan stok miktarı: " + kalanStok);

            Console.Read();
        }
    }
}
