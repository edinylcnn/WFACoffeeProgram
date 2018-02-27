using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKahveOtomasyonu
{
    public class Ekstra
    {
        public string Adi { get; set; }
        public decimal FiyatFarki { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
