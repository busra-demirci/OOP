using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface2
{
    public class Insan : Omurgali, IInsan
    {
        public string GozRengi { get; set; }
        public string SacRengi { get; set; }

        public string DansEt()
        {
            return "Dans ediyorum...";
        }

        public string Konus()
        {
            return "Konuşuyorum...";
        }

        public string OyunOyna()
        {
            return "Oyun oynuyorum...";
        }
    }
}
