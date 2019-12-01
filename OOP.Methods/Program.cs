using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kodu 1 kez yazıp N kez kullanmak (OOP temel amaç).
            /*
            int sonuc = Topla(3, 5, 7);
            var sonuc2 = "15"; // eşitliğin sağında hangi tip varsa, "var" o tipe bürünür.
            object sonuc3 = 10; //istenilen değer atanabilir. int, string, datetime.. Object, karşısındaki veri tipine bürünmez. O her şeyi kapsar.
            Console.WriteLine(sonuc3);
            Console.Read();
            */

            /*
            int toplam = 0;
            int carpim = 0;

            ToplaCarp(3, 5, out toplam, out carpim); // çağırırken, verdiğimiz parametrenin "out" tipinde bir parametre olduğu belirtilmelidir. Out ve Ref bilinmeli ancak kullanımı kod kalabalığına sebep olacağından tercih edilmez.

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
            Console.Read();
            */

            /*
            int sayi1 = 10;
            int sayi2 = 5;
            int carpanVeSonuc = 3;

            CıkarCarp(sayi1, sayi2, ref carpanVeSonuc);
            Console.WriteLine("Sonuç: " + carpanVeSonuc);
            Console.Read();
            */

            var toplam = Topla(3, 6, 7, 8, 10, 17, 20, 32, 68, 108, 125);

            Console.WriteLine("Toplam: "+toplam);

            Console.Read();

        }
        /// <summary>
        /// 2 sayının toplamını verir.
        /// </summary>
        /// <param name="a">Sayı1</param>
        /// <param name="b">Sayı2</param>
        /// <returns>int</returns>
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 3 sayının toplamını verir.
        /// </summary>
        /// <param name="a">Sayı 1</param>
        /// <param name="b">Sayı 2</param>
        /// <param name="c">Sayı 3</param>
        /// <returns>int</returns>
        public static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// 2 sayının toplamını ve çarpımını verir.
        /// </summary>
        /// <param name="sayi1">Sayı1</param>
        /// <param name="sayi2">Sayı2</param>
        /// <param name="toplam">Toplam Sonucu</param>
        /// <param name="carpim">Çarpım Sonucu</param>
        public static void ToplaCarp(int sayi1, int sayi2, out int toplam, out int carpim)
        {
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
        }

        /// <summary>
        /// 2 sayının farkını çarpan değeri ile çarpıp, carpan değerinin çıktısı olarak verir.
        /// </summary>
        /// <param name="sayi1">Sayi1</param>
        /// <param name="sayi2">Sayi2</param>
        /// <param name="carpanVeSonuc">carpan</param>
        public static void CıkarCarp(int sayi1, int sayi2, ref int carpanVeSonuc)
        {
            carpanVeSonuc = (sayi1 - sayi2) * carpanVeSonuc;
            // ref parametre değişkenlerin ilk değerlerini işleme sokup dışarıya çıktı verebilirken out bunu yapamaz. out parametre tek yönlü iken ref parametre iki yönlü çalışır. 
        }
        /// <summary>
        /// Verilen sayıların toplamını döndürür.
        /// </summary>
        /// <param name="sayilar">Sayılar</param>
        /// <returns>int</returns>
        public static int Topla(params int[] sayilar)
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam+= sayilar[i];  // toplam = toplam + sayilar[i];
            }
            return toplam;
        }
    }
}
