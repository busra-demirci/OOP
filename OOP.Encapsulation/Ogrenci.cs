using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Ogrenci
    {
        public int Not { get; set; }

        public bool BasariliMi
        {
            get
            {
                if (Not >= 60)
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
}
