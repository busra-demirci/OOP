using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel
            {
                Isim = "Bülent",
                Soyisim = "Başyurt",
                Maas = 5000,
                KullaniciAdi = "bülentbaşyurt",
                Sifre = "123"
            };    
            
            //Hata verir.
            //Validasyon v=new Validasyon();

            bool yetkiliMi = Validasyon.KullaniciDogrula(personel.KullaniciAdi, personel.Sifre);

            if (yetkiliMi)
            {
                Console.WriteLine("Kullanıcı doğrulama başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre");
            }
        }
    }
}
