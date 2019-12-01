using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    /*
     * Inheritance
     * Abstraction
     * Encapsulation
     * Polymorphism
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Insan insan1 = new Insan();
            // insan1 sonrası nokta koyduğumuz anda miras alınan tüm classların propertylerine erişim sağlayabiliyoruz. (insan1.)
            */

            Otomobil otomobil1 = new Otomobil();
            otomobil1.Marka = "BMW";
            otomobil1.Model = "M6";
            otomobil1.Renk = "Mavi";
            otomobil1.TekerlekSayisi = 4;
            otomobil1.Fiyat = 1000000;

            otomobil1.KapiSayisi = 2;
            otomobil1.YakitTuru = "Benzin";
            otomobil1.BagajHacmi = "495cc";

            //Console.WriteLine(otomobil1.ToString());

            //Console.WriteLine();

            //Console.WriteLine("***************************");

            //Console.WriteLine();

            Otomobil otomobil2 = new Otomobil();
            otomobil2.Marka = "Audi";
            otomobil2.Model = "A4";
            otomobil2.Renk = "Siyah";
            otomobil2.TekerlekSayisi = 4;
            otomobil2.Fiyat = 300000;

            otomobil2.KapiSayisi = 4;
            otomobil2.YakitTuru = "Dizel";
            otomobil2.BagajHacmi = "565cc";


            //Console.WriteLine(otomobil2.ToString());

            //Console.WriteLine();

            //Console.WriteLine("***************************");

            //Console.WriteLine();


            Motosiklet motosiklet1 = new Motosiklet();
            motosiklet1.Marka = "Honda";
            motosiklet1.Model = "CBR 1000RR";
            motosiklet1.Renk = "Kırmızı";
            motosiklet1.TekerlekSayisi = 2;
            motosiklet1.Fiyat = 90000;

            motosiklet1.MotorHacmi = 1000;

            //Console.WriteLine(motosiklet1.ToString());

            //Console.WriteLine();

            //Console.WriteLine("*************************");

            //Console.WriteLine();

            Motosiklet motosiklet2 = new Motosiklet();
            motosiklet2.Marka = "Yamaha";
            motosiklet2.Model = "YZF R6";
            motosiklet2.Renk = "Siyah";
            motosiklet2.TekerlekSayisi = 2;
            motosiklet2.Fiyat = 70000;

            motosiklet2.MotorHacmi = 600;

            //Console.WriteLine(motosiklet2.ToString());

            //Console.WriteLine();

            //Console.WriteLine("*************************");

            //Console.WriteLine();

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.Marka = "Salcano";
            bisiklet.Model = "NG 750";
            bisiklet.Renk = "Siyah";
            bisiklet.TekerlekSayisi = 2;
            bisiklet.Fiyat = 1000;

            bisiklet.SelesiVarMi = false;
            bisiklet.VitesSayisi = 21;

            //Console.WriteLine(bisiklet.ToString());
            var kdvliFiyat = bisiklet.KDVliFiyatHesapla(5);
            Console.Read();


        }
    }
}
