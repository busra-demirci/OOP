using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Ayakkabi ayakkabi = new Ayakkabi
            {
                Numara = 43,
                Renk = Enums.Renk.Beyaz,
                Tur = Enums.Tur.Spor
            };

            Console.WriteLine(ayakkabi.ToString());
            Console.Read();
        }
    }
}
