using DenemeBorsa.DAL;
using DenemeBorsa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeBorsa.UI
{
    public partial class FormKayit : Form
    {
        private bool admin;
        public FormKayit(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            lblSifre.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var checkName = txtKullaniciAdi.Text.Trim().ToLower();
            var durum = KullaniciAdiKontrol(checkName);
            if (durum)
            {
                MessageBox.Show("Kullanıcı adı uygun, alabilirsiniz...");
            }

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            var dogum = dtpDogumTarihi.Value;
            var durumYas = YasKontrol(dogum);

            if (durumYas)
            {
                KullaniciKaydet();
            }
            else
            {
                MessageBox.Show("Yaşınız 18'den küçük!!!");
            }
            
        }

        private void NoSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyLetter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyLetterOrDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }

        }

        private void KullaniciKaydet()
        {
            bool durumKullanici = KullaniciAdiKontrol(txtKullaniciAdi.Text);
            bool durumVeri = string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                             string.IsNullOrEmpty(txtSifre.Text) ||
                             string.IsNullOrEmpty(txtSifreTekrar.Text) ||
                             string.IsNullOrEmpty(txtAd.Text) ||
                             string.IsNullOrEmpty(txtSoyad.Text) ||
                             string.IsNullOrEmpty(txtTcKimlikNo.Text) ||
                             cmbTip.SelectedIndex == -1;


            if (durumVeri)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!","Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (durumKullanici)
                {
                    bool durumTCKimlik = TcKimlikNoKontrol(txtTcKimlikNo.Text);
                    if (durumTCKimlik)
                    {
                        BorsaKullanici b = new BorsaKullanici()
                        {
                            Tur = cmbTip.SelectedIndex + 1,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            Sifre = txtSifre.Text,
                            TcKimlikNo = txtTcKimlikNo.Text,
                            Adi = txtAd.Text.Trim().ToLower(),
                            Soyadi = txtSoyad.Text.Trim().ToUpper(),
                            DogumTarihi = dtpDogumTarihi.Value,
                            Telefon = mTxtTelefon.Text,
                            Email = txtMail.Text,
                            Adres = txtAdres.Text,
                            isDeleted = false,
                            KayitTarihi = DateTime.Now
                        };

                        var durumKayit = HelperBorsaKullanici.CUD(b, EntityState.Added);
                        if (durumKayit.Item1)
                        {
                            if (admin)
                            {
                                MessageBox.Show("Kullanıcı Kaydı Başarılı.");
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Kaydı Başarılı. Ana Menuye Yönlendiriliyorsunuz...",
                                "Kayıt Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                int giris = HelperBorsaKullanici.getIDfromUser(txtKullaniciAdi.Text);
                                FormMenu fm = new FormMenu(giris);
                                fm.Show();
                                this.Close();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Kayıt sırasında bir hata oluştu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir TC Kimlik No giriniz.", "Kimlik No Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                   
                }              
            }

        }

        private bool YasKontrol(DateTime dogumTarihi)
        {
            var yas = (DateTime.Now.Year - dogumTarihi.Year);
            if (yas >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool KullaniciAdiKontrol(string kullaniciAdi)
        {
            var durum = HelperBorsaKullanici.checkUserName(kullaniciAdi);
            if (durum)
            {
                lblInfo.Visible = true;
            }
            else
            {
                lblInfo.Visible = false;               
            }
            return !durum;


        }

        private void SifreKontrol(object sender, EventArgs e)
        {
            bool durumSifre = txtSifreTekrar.Text.Equals(txtSifre.Text);
            if (durumSifre)
            {
                lblSifre.Visible = false;
            }
            else
            {
                lblSifre.Visible = true;
            }
        }

        private bool TcKimlikNoKontrol(string tcNo)
        {
            if (tcNo.Length <11)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
