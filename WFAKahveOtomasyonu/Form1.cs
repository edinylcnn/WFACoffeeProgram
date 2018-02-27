using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAKahveOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kahve> kahve = new List<Kahve>()
            {
                new Kahve {Adi="Americano",Fiyat=8 },
                new Kahve {Adi="Espresso",Fiyat=5 },
                new Kahve {Adi="Cappucino",Fiyat=7 },
                new Kahve {Adi="Mocha", Fiyat=6 }
            };
            List<Boyut> boy = new List<Boyut>()
            {
                new Boyut {Adi="Vendi", Carpan=1 },
                new Boyut {Adi="Grande",Carpan=1.25 },
                new Boyut {Adi="Tall", Carpan=1.5 }
            };

            foreach (Kahve k in kahve)
            {
                cmbKahveler.Items.Add(k);
            }
            foreach (Boyut b in boy)
            {
                cmbBoy.Items.Add(b);
            }
            Ekstra olcek1x = new Ekstra() { Adi = "1x Shot", FiyatFarki = 1 };
            rdb1x.Tag = olcek1x;
            Ekstra olcek2x = new Ekstra() { Adi = "2x Shot", FiyatFarki = 2 };
            rdb2x.Tag = olcek2x;

            Ekstra normalSut = new Ekstra() { Adi = "Normal Süt", FiyatFarki = 1 };
            rdbNormalSut.Tag = normalSut;
            Ekstra laktozsuzSut = new Ekstra() { Adi = "Laktozsuz Süt", FiyatFarki = 2 };
            rdbLaktozsuz.Tag = laktozsuzSut;
        }
        Siparis s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kahve k =(Kahve) cmbKahveler.SelectedItem;
            k.Boy =(Boyut) cmbBoy.SelectedItem;
            //if (rdb1x.Checked)
            //{
            //    k.Ekstra = (Ekstra)rdb1x.Tag;
            //}
            //if (rdb2x.Checked)
            //{
            //    k.Ekstra =(Ekstra) rdb2x.Tag;
            //}
            if (rdb1x.Checked) k.Ekstra = (Ekstra)rdb1x.Tag;
            else if (rdb2x.Checked) k.Ekstra = (Ekstra)rdb2x.Tag;
            else if (rdbLaktozsuz.Checked) k.Ekstra = (Ekstra)rdbLaktozsuz.Tag;
            else k.Ekstra = (Ekstra)rdbNormalSut.Tag;

            decimal tutar = nudAdet.Value * k.Tutar;
            lblTutar.Text = tutar.ToString();
            s = new Siparis();
            s.MusteriAdSoyad = txtAdSoyad.Text;
            s.Adet =(int) nudAdet.Value;
            s.Kahve = k;

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s!=null)
            {
                listBox1.Items.Add(s);
            }
            decimal toplamTutar = 0;
            foreach (Siparis siparis in listBox1.Items)
            {
                toplamTutar += siparis.Adet * siparis.Kahve.Tutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            int sayac = 0;
            foreach (Siparis s in listBox1.Items)
            {
                toplamTutar += s.Adet * s.Kahve.Tutar;
                sayac++;
            }
            MessageBox.Show(string.Format("Toplam Sipariş Adedi: {0},\n Toplam Tutar: {1}",sayac,toplamTutar));
        }
    }
}
