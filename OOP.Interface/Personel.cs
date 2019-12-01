using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public class Personel : IPersonel, ICalisma
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public decimal Maas { get; set; }
        public Enums.Pozisyon Pozisyon { get; set; }

        public decimal MaasHesapla(Enums.Pozisyon pozisyon)
        {
            if (pozisyon == Enums.Pozisyon.YazilimGelistirici)
            {
                return 5000;
            }
            else if (pozisyon == Enums.Pozisyon.Analist)
            {
                return 4000;
            }
            else
            {
                return 3000;
            }
        }

        public string KodYaz()
        {
            return "C# yazıyorum...";
        }

        public string ToplantiYap()
        {
            return "Toplantı yapıyorum...";
        }
    }
}
