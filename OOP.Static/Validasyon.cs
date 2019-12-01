using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    /*
     * Static sınıflar uygulama ilk çalıştığı anda belleğe alınır.
     * Statik sınıfların örneği alınamaz.
     * Statik sınıfların tüm memberları statik olmak zorundadır.
     */
    public static class Validasyon
    {
        static int sayi = 5;

        public static void MaasHesapla()
        {

        }

        public static bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "bülentbaşyurt" && sifre == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
