namespace WFAKahveOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbMusteriBilgisi = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbIcecekler = new System.Windows.Forms.GroupBox();
            this.cmbBoy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKahveler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEkstralar = new System.Windows.Forms.GroupBox();
            this.rdbLaktozsuz = new System.Windows.Forms.RadioButton();
            this.rdbNormalSut = new System.Windows.Forms.RadioButton();
            this.rdb2x = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdb1x = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.gbMusteriBilgisi.SuspendLayout();
            this.gbIcecekler.SuspendLayout();
            this.gbEkstralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kahve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMusteriBilgisi
            // 
            this.gbMusteriBilgisi.Controls.Add(this.txtTelefon);
            this.gbMusteriBilgisi.Controls.Add(this.txtAdSoyad);
            this.gbMusteriBilgisi.Controls.Add(this.label3);
            this.gbMusteriBilgisi.Controls.Add(this.label2);
            this.gbMusteriBilgisi.Location = new System.Drawing.Point(20, 97);
            this.gbMusteriBilgisi.Name = "gbMusteriBilgisi";
            this.gbMusteriBilgisi.Size = new System.Drawing.Size(303, 97);
            this.gbMusteriBilgisi.TabIndex = 1;
            this.gbMusteriBilgisi.TabStop = false;
            this.gbMusteriBilgisi.Text = "Müşteri Bilgisi";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(72, 50);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(166, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(72, 23);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(166, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı:";
            // 
            // gbIcecekler
            // 
            this.gbIcecekler.Controls.Add(this.cmbBoy);
            this.gbIcecekler.Controls.Add(this.label5);
            this.gbIcecekler.Controls.Add(this.cmbKahveler);
            this.gbIcecekler.Controls.Add(this.label4);
            this.gbIcecekler.Location = new System.Drawing.Point(20, 200);
            this.gbIcecekler.Name = "gbIcecekler";
            this.gbIcecekler.Size = new System.Drawing.Size(303, 108);
            this.gbIcecekler.TabIndex = 4;
            this.gbIcecekler.TabStop = false;
            this.gbIcecekler.Text = "İçecek";
            // 
            // cmbBoy
            // 
            this.cmbBoy.FormattingEnabled = true;
            this.cmbBoy.Location = new System.Drawing.Point(91, 56);
            this.cmbBoy.Name = "cmbBoy";
            this.cmbBoy.Size = new System.Drawing.Size(163, 21);
            this.cmbBoy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "İçecek Boyutu:";
            // 
            // cmbKahveler
            // 
            this.cmbKahveler.FormattingEnabled = true;
            this.cmbKahveler.Location = new System.Drawing.Point(88, 19);
            this.cmbKahveler.Name = "cmbKahveler";
            this.cmbKahveler.Size = new System.Drawing.Size(166, 21);
            this.cmbKahveler.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kahveler:";
            // 
            // gbEkstralar
            // 
            this.gbEkstralar.Controls.Add(this.rdbLaktozsuz);
            this.gbEkstralar.Controls.Add(this.rdbNormalSut);
            this.gbEkstralar.Controls.Add(this.rdb2x);
            this.gbEkstralar.Controls.Add(this.label7);
            this.gbEkstralar.Controls.Add(this.rdb1x);
            this.gbEkstralar.Controls.Add(this.label6);
            this.gbEkstralar.Location = new System.Drawing.Point(20, 314);
            this.gbEkstralar.Name = "gbEkstralar";
            this.gbEkstralar.Size = new System.Drawing.Size(303, 100);
            this.gbEkstralar.TabIndex = 4;
            this.gbEkstralar.TabStop = false;
            this.gbEkstralar.Text = "Ekstralar";
            // 
            // rdbLaktozsuz
            // 
            this.rdbLaktozsuz.AutoSize = true;
            this.rdbLaktozsuz.Location = new System.Drawing.Point(169, 50);
            this.rdbLaktozsuz.Name = "rdbLaktozsuz";
            this.rdbLaktozsuz.Size = new System.Drawing.Size(73, 17);
            this.rdbLaktozsuz.TabIndex = 1;
            this.rdbLaktozsuz.TabStop = true;
            this.rdbLaktozsuz.Text = "Laktozsuz";
            this.rdbLaktozsuz.UseVisualStyleBackColor = true;
            // 
            // rdbNormalSut
            // 
            this.rdbNormalSut.AutoSize = true;
            this.rdbNormalSut.Location = new System.Drawing.Point(72, 50);
            this.rdbNormalSut.Name = "rdbNormalSut";
            this.rdbNormalSut.Size = new System.Drawing.Size(58, 17);
            this.rdbNormalSut.TabIndex = 1;
            this.rdbNormalSut.TabStop = true;
            this.rdbNormalSut.Text = "Normal";
            this.rdbNormalSut.UseVisualStyleBackColor = true;
            // 
            // rdb2x
            // 
            this.rdb2x.AutoSize = true;
            this.rdb2x.Location = new System.Drawing.Point(169, 27);
            this.rdb2x.Name = "rdb2x";
            this.rdb2x.Size = new System.Drawing.Size(36, 17);
            this.rdb2x.TabIndex = 1;
            this.rdb2x.TabStop = true;
            this.rdb2x.Text = "2x";
            this.rdb2x.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Süt:";
            // 
            // rdb1x
            // 
            this.rdb1x.AutoSize = true;
            this.rdb1x.Location = new System.Drawing.Point(72, 27);
            this.rdb1x.Name = "rdb1x";
            this.rdb1x.Size = new System.Drawing.Size(36, 17);
            this.rdb1x.TabIndex = 1;
            this.rdb1x.TabStop = true;
            this.rdb1x.Text = "1x";
            this.rdb1x.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Shot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(67, 419);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(61, 20);
            this.nudAdet.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(134, 416);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(91, 23);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tutar:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(284, 421);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(29, 13);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "0 TL";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepeteEkle.Location = new System.Drawing.Point(20, 459);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(303, 47);
            this.btnSepeteEkle.TabIndex = 9;
            this.btnSepeteEkle.Text = "SEPETE EKLE";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(329, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(588, 316);
            this.listBox1.TabIndex = 10;
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.Location = new System.Drawing.Point(590, 459);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(327, 47);
            this.btnSiparis.TabIndex = 11;
            this.btnSiparis.Text = "SİPARİŞ VER";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(578, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(748, 426);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(93, 29);
            this.lblToplamTutar.TabIndex = 13;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbEkstralar);
            this.Controls.Add(this.gbIcecekler);
            this.Controls.Add(this.gbMusteriBilgisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMusteriBilgisi.ResumeLayout(false);
            this.gbMusteriBilgisi.PerformLayout();
            this.gbIcecekler.ResumeLayout(false);
            this.gbIcecekler.PerformLayout();
            this.gbEkstralar.ResumeLayout(false);
            this.gbEkstralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMusteriBilgisi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbIcecekler;
        private System.Windows.Forms.ComboBox cmbBoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKahveler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEkstralar;
        private System.Windows.Forms.RadioButton rdbLaktozsuz;
        private System.Windows.Forms.RadioButton rdbNormalSut;
        private System.Windows.Forms.RadioButton rdb2x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb1x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}

