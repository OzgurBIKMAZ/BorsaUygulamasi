namespace DenemeBorsa.UI
{
    partial class FormKisiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKisiGuncelle));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.mTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dtpDogumTarihi);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.txtTcKimlikNo);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.txtSoyad);
            this.groupBox9.Controls.Add(this.txtAd);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.Location = new System.Drawing.Point(12, 155);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(354, 175);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Kişisel Bilgiler";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(117, 131);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 21);
            this.dtpDogumTarihi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Doğum Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC Kimlik No : ";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.Location = new System.Drawing.Point(115, 27);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(202, 21);
            this.txtTcKimlikNo.TabIndex = 14;
            this.txtTcKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigit);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(41, 95);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 15);
            this.label23.TabIndex = 13;
            this.label23.Text = "Soyadı :  ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(64, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 15);
            this.label25.TabIndex = 11;
            this.label25.Text = "Adı : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(115, 89);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(202, 21);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(115, 56);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(202, 21);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetter);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.txtAdres);
            this.groupBox8.Controls.Add(this.mTxtTelefon);
            this.groupBox8.Controls.Add(this.txtMail);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(14, 340);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(354, 201);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "İletişim Bilgileri";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(44, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Adres : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(42, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 16);
            this.label20.TabIndex = 15;
            this.label20.Text = "E-mail : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(34, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "Telefon : ";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(117, 105);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(202, 78);
            this.txtAdres.TabIndex = 10;
            // 
            // mTxtTelefon
            // 
            this.mTxtTelefon.Location = new System.Drawing.Point(115, 32);
            this.mTxtTelefon.Mask = "(999) 000-0000";
            this.mTxtTelefon.Name = "mTxtTelefon";
            this.mTxtTelefon.Size = new System.Drawing.Size(149, 21);
            this.mTxtTelefon.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(202, 21);
            this.txtMail.TabIndex = 8;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoSpace);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 137);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtTur
            // 
            this.txtTur.Enabled = false;
            this.txtTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.Location = new System.Drawing.Point(113, 27);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(202, 21);
            this.txtTur.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tur : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kullanıcı Adı : ";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(113, 95);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(202, 21);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoSpace);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(113, 54);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(202, 21);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(14, 547);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(352, 59);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormKisiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(399, 641);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKisiGuncelle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormKisiselBilgiler_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox mTxtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}