using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Mercedes";
            otomobil.Fiyat = 200000;
            var kdvliFiyat = otomobil.FiyatHesapla();

            Console.WriteLine("Otomobil ile " + otomobil.HizYap());

            Motosiklet motosiklet = new Motosiklet();
            motosiklet.Fiyat = 100000;

            Console.WriteLine("Motosiklet ile " + motosiklet.HizYap());

            Console.Read();
        }
    }
}
