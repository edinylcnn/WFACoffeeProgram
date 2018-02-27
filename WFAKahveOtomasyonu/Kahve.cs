using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKahveOtomasyonu
{
    public class Kahve
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Boyut Boy { get; set; }
        public Ekstra Ekstra { get; set; }

        public decimal Tutar
        {
            get
            {
                decimal toplam = 0;
                toplam = Fiyat * (decimal)Boy.Carpan;
                toplam += Ekstra.FiyatFarki;
                return toplam;
            }
        }
        public override string ToString()
        {
            return Adi;
        }
    }
    
}
