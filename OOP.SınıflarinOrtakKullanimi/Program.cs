using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SınıflarinOrtakKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Departman departman1 = new Departman
            {
                DepartmanId = 1,
                DepartmanAdi = "IT Departmanı",
                Gorevi = "Şirketin IT operasyonlarını yürütmek.",
                Muduru = "Ali Veli"
            };

            Pozisyon pozisyon1 = new Pozisyon
            {
                PozisyonId = 5,
                PozisyonAdi = "Junior Developer",
                DepartmanId = 1,
                Gorevi = "Yazılım geliştirmek",
                Maas = 2500
            };

            Personel personel = new Personel
            {
                AdSoyad = "Bülent Başyurt",
                Departman = departman1,
                Pozisyon = pozisyon1
            };

            Personel personel2 = new Personel();
            personel2.AdSoyad = "Yasin Şafak";
            personel2.Departman = departman1;
            personel2.Pozisyon = pozisyon1;

            Console.WriteLine(personel2.ToString());
            Console.Read();
        }
    }
}
