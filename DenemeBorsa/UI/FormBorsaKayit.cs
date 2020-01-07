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
    public partial class FormBorsaKayit : Form
    {
        public FormBorsaKayit()
        {
            InitializeComponent();
        }

        private void FormBorsaKayit_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
           bool durumEkle = string.IsNullOrEmpty(txtAd.Text) ||
                            string.IsNullOrEmpty(txtAlis.Text) ||
                            string.IsNullOrEmpty(txtSatis.Text) ||
                            cmbTur.SelectedIndex == -1;

            if (durumEkle)
            {
                MessageBox.Show("Tüm değerleri giriniz.", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var durumIsim = CheckMenkul();
                if (durumIsim)
                {
                    Borsa b = new Borsa()
                    {
                        Adi = txtAd.Text,
                        Tur = cmbTur.SelectedIndex + 1,
                        isDeleted = false,
                        Tarih = DateTime.Now
                    };
                    var addBorsa = HelperBorsa.CUD(b, EntityState.Added);

                    if (addBorsa.Item1)
                    {
                        BorsaIslem bi = new BorsaIslem()
                        {
                            BorsaID = addBorsa.Item2.BorsaID,
                            Alis = double.Parse(txtAlis.Text),
                            Satis = double.Parse(txtSatis.Text),
                            Degisim = 0,
                            Tarih = DateTime.Now
                        };

                        var addIslem = HelperBorsaIslem.Add(bi);

                        if (addIslem)
                        {
                            MessageBox.Show("Menkul başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Menkul değer atama sırasında bir hata meydana geldi..");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Menkul oluşturma sırasında bir hata meydana geldi..");
                    }
                }

            }

        }

        private void OnlyLetterOrDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private bool CheckMenkul()
        {
            var checkName = txtAd.Text.ToLower();
            var durum = HelperBorsa.checkName(checkName);
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
    }
}
