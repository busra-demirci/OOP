using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface2
{
    public abstract class Canli : ICanli
    {
        public string Agirlik { get; set; }        

        public string Beslen()
        {
            return "Besleniyorum...";
        }

        public string SolunumYap()
        {
            return "Nefes alıyorum...";
        }
    }
}
