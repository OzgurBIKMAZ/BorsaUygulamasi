namespace DenemeBorsa.UI
{
    partial class FormGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.imgEye = new System.Windows.Forms.ImageList(this.components);
            this.timerSayac = new System.Windows.Forms.Timer(this.components);
            this.btnEye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(28, 22);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(231, 24);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetterOrDigit);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitOl.Image")));
            this.btnKayitOl.Location = new System.Drawing.Point(231, 186);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(81, 65);
            this.btnKayitOl.TabIndex = 1;
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSifre.Location = new System.Drawing.Point(28, 68);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(231, 24);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Text = "Şifre Giriniz";
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoSpace);
            this.txtSifre.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSifre_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.Location = new System.Drawing.Point(132, 108);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(127, 34);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // imgEye
            // 
            this.imgEye.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEye.ImageStream")));
            this.imgEye.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEye.Images.SetKeyName(0, "eye_open.jpg");
            this.imgEye.Images.SetKeyName(1, "eye_close.jpg");
            // 
            // timerSayac
            // 
            this.timerSayac.Tick += new System.EventHandler(this.timerSayac_Tick);
            // 
            // btnEye
            // 
            this.btnEye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEye.BackgroundImage")));
            this.btnEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEye.Location = new System.Drawing.Point(265, 64);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(38, 32);
            this.btnEye.TabIndex = 7;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(320, 255);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGiris";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Timer timerSayac;
        private System.Windows.Forms.ImageList imgEye;
        private System.Windows.Forms.Button btnEye;
    }
}