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
using static DenemeBorsa.DAL.Enums;

namespace DenemeBorsa.UI
{
    public partial class FormKisiGuncelle : Form
    {
        BorsaKullanici user;
        public FormKisiGuncelle(BorsaKullanici user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormKisiselBilgiler_Load(object sender, EventArgs e)
        {
            txtTur.Text = ((UserTur)user.Tur).ToString();
            txtKullaniciAdi.Text = user.KullaniciAdi;
            txtSifre.Text = user.Sifre;
            txtTcKimlikNo.Text = user.TcKimlikNo;
            txtAd.Text = user.Adi;
            txtSoyad.Text = user.Soyadi;
            dtpDogumTarihi.Value = user.DogumTarihi;
            mTxtTelefon.Text = user.Telefon;
            txtMail.Text = user.Email;
            txtAdres.Text = user.Adres;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle();
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

        private void NoSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KullaniciGuncelle()
        {
            bool durumVeri = string.IsNullOrEmpty(txtSifre.Text) ||
                             string.IsNullOrEmpty(txtAd.Text) ||
                             string.IsNullOrEmpty(txtSoyad.Text) ||
                             string.IsNullOrEmpty(txtTcKimlikNo.Text);


            if (durumVeri)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool durumTCKimlik = TcKimlikNoKontrol(txtTcKimlikNo.Text);
                if (durumTCKimlik)
                {
                    BorsaKullanici b = new BorsaKullanici()
                    {
                        KullaniciID = user.KullaniciID,
                        Tur = user.Tur,
                        KullaniciAdi = user.KullaniciAdi,
                        Sifre = txtSifre.Text,
                        TcKimlikNo = txtTcKimlikNo.Text,
                        Adi = txtAd.Text.Trim().ToLower(),
                        Soyadi = txtSoyad.Text.Trim().ToUpper(),
                        DogumTarihi = dtpDogumTarihi.Value,
                        Telefon = mTxtTelefon.Text,
                        Email = txtMail.Text,
                        Adres = txtAdres.Text,
                        isDeleted = false,
                        KayitTarihi = user.KayitTarihi
                    };

                    var durumKayit = HelperBorsaKullanici.CUD(b, EntityState.Modified);
                    if (durumKayit.Item1)
                    {
                        MessageBox.Show("Güncelleme Başarılı.");
                        this.Close();
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
        
        private bool TcKimlikNoKontrol(string tcNo)
        {
            if (tcNo.Length < 11)
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
