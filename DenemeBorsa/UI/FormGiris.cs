using DenemeBorsa.DAL;
using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeBorsa.UI
{
    public partial class FormGiris : Form
    {
        bool durumGizli = true;
        bool durumKullaniciAd = true;
        bool durumSifre = true;
        int sayac = 0;
        List<Borsa> borsaTur = new List<Borsa>();
        static Random r = new Random();
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            borsaTur = HelperBorsa.getAllRecords(false);
            timerSayac.Interval = 200;
            timerSayac.Start();

        }

        private void timerSayac_Tick(object sender, EventArgs e)
        {
            sayac++;
            DegerYukle(sayac);
        }

        private void DegerYukle(int say)
        {
            if (say % 22 == 0)
            {
                foreach (var item in borsaTur)
                {
                    var last = HelperBorsaIslem.getLastRecord(item.BorsaID);
                    if (last != null)
                    {
                        var alis = ArtisBelirle(last.Alis);
                        BorsaIslem b = new BorsaIslem()
                        {
                            BorsaID = last.BorsaID,
                            Alis = alis,
                            Satis = ArtisBelirle(last.Alis),
                            Degisim = (last.Alis - alis) / last.Alis,
                            Tarih = DateTime.Now,
                        };
                        var a = HelperBorsaIslem.Add(b);
                    }
                    
                }
               

            }
        }

        private double ArtisBelirle( double say)
        {
            int artis = 0;
            if (r.Next() % 2 == 0)
            {
                artis = 1;
            }
            else
            {
                artis = -1;
            }

            var miktar = r.NextDouble() / 10;

            say += say * artis * miktar;
            return say;
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            if (durumKullaniciAd)
            {
                txtKullaniciAdi.ForeColor = Color.Black;
                txtKullaniciAdi.Clear();
                durumKullaniciAd = false;
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (durumSifre)
            {
                txtSifre.ForeColor = Color.Black;
                txtSifre.Clear();
                durumSifre = false;
            }

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtKullaniciAdi.Text.ToLower().Trim();
            string userPass = txtSifre.Text.Trim();

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userPass) && !userName.Equals("kullanıcı adı"))
            {
                var giris = HelperBorsaKullanici.checkUserLogin(userName, userPass);

                if (giris.Item1)
                {
                    if (giris.Item3)
                    {
                        MessageBox.Show("Bu kullanıcı pasif duruma geçmiştir.\n" +
                            "Lütfen adminle iletişime geçiniz", "Kullanıcı Pasif Durumda", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        FormMenu fm = new FormMenu(giris.Item2);
                        fm.Show();
                        timerSayac.Start();
                        this.Hide();
                    }                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!! Lütfen tekrar deneyiniz...",
                        "Giriş Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre boş bırakılamaz!!!",
                     "Giriş Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FormKayit fk = new FormKayit(false);
            fk.Show();
            timerSayac.Start();
            this.Hide();
        }

        private void OnlyLetterOrDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NoSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (durumGizli)
            {
                txtSifre.PasswordChar = '\0';
                durumGizli = false;
            }
            else
            {
                txtSifre.PasswordChar = '*';
                durumGizli = true;
            }
        }
    }
}
