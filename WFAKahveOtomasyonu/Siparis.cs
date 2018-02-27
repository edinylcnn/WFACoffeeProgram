using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKahveOtomasyonu
{
    public class Siparis
    {
        public string MusteriAdSoyad { get; set; }
        public string Telefon { get; set; }
        public Kahve Kahve { get; set; }
        public Boyut Boyut { get; set; }
        public Ekstra Ekstra { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", MusteriAdSoyad, Kahve.Adi, Kahve.Boy, Kahve.Ekstra, Adet);
        }

    }
}
