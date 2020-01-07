using DenemeBorsa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DenemeBorsa.DAL.Enums;

namespace DenemeBorsa.UI
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
            KisileriYukle(false);
            btnGeriYukle.Enabled = false;
            btnBorsaGeriYukle.Enabled = false;
            BorsaYukle(false);
            BorsaIslemYukle(false);
            KullaniciIslemYukle(false);
        }

        private void ComboBoxDoldur()
        {
            var list = HelperBorsa.getAllRecords(false);
            cmbIslem.ValueMember = "BorsaID";
            cmbIslem.DisplayMember = "Adi";
            cmbIslem.DataSource = list;
        }

        private void KisileriYukle(bool deleted)
        {
            dataKullanıcılar.Rows.Clear();
            var kullaniciList = HelperBorsaKullanici.getAllRecords();
            foreach (var bk in kullaniciList)
            {
                if (bk.isDeleted == deleted)
                {
                    int satir = dataKullanıcılar.Rows.Add();
                    dataKullanıcılar.Rows[satir].Cells[0].Value = bk.KullaniciID;
                    dataKullanıcılar.Rows[satir].Cells[1].Value = (UserTur)bk.Tur;
                    dataKullanıcılar.Rows[satir].Cells[2].Value = bk.KullaniciAdi;
                    dataKullanıcılar.Rows[satir].Cells[3].Value = bk.Sifre;
                    dataKullanıcılar.Rows[satir].Cells[4].Value = bk.KayitTarihi;
                }
                
             }
        }

        private void BorsaYukle(bool deleted)
        {
            dataBorsa.Rows.Clear();
            var borsaList = HelperBorsa.getAllRecords(deleted);
            foreach (var b in borsaList)
            {
                int satir = dataBorsa.Rows.Add();
                dataBorsa.Rows[satir].Cells[0].Value = b.BorsaID;
                dataBorsa.Rows[satir].Cells[1].Value = (BorsaTur)b.Tur;
                dataBorsa.Rows[satir].Cells[2].Value = b.Adi;
                dataBorsa.Rows[satir].Cells[3].Value = b.Tarih;
            }
        }

        private void BorsaIslemYukle(bool deleted)
        {
            dataBorsaIslem.Rows.Clear();
            var islemList = HelperBorsaIslem.getAllRecords();
            foreach (var i in islemList)
            {
                int satir = dataBorsaIslem.Rows.Add();
                dataBorsaIslem.Rows[satir].Cells[0].Value = i.IslemID;
                dataBorsaIslem.Rows[satir].Cells[1].Value = i.Borsa.Adi;
                dataBorsaIslem.Rows[satir].Cells[2].Value = i.Alis;
                dataBorsaIslem.Rows[satir].Cells[3].Value = i.Satis;
                dataBorsaIslem.Rows[satir].Cells[4].Value = i.Degisim;
                dataBorsaIslem.Rows[satir].Cells[5].Value = i.Tarih;
            }
        }

        private void KullaniciIslemYukle(bool deleted)
        {
            dataKullaniciIslem.Rows.Clear();
            var islemList = HelperBorsaKullaniciIslem.getAllRecords();
            foreach (var i in islemList)
            {
                if (i.isDeleted == deleted)
                {
                    int satir = dataKullaniciIslem.Rows.Add();
                    dataKullaniciIslem.Rows[satir].Cells[0].Value = i.KullaniciIslemID;
                    dataKullaniciIslem.Rows[satir].Cells[1].Value = i.KullaniciID;
                    dataKullaniciIslem.Rows[satir].Cells[2].Value = i.Borsa.Adi;
                    dataKullaniciIslem.Rows[satir].Cells[3].Value = i.Miktar;
                    dataKullaniciIslem.Rows[satir].Cells[4].Value = i.Tarih;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataKullanıcılar);
            var selectedUser = HelperBorsaKullanici.getRecordbyID(selectedID);
            FormKisiGuncelle fkb = new FormKisiGuncelle(selectedUser);
            fkb.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            KisileriYukle(false);
            btnGeriYukle.Enabled = false;
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            KisileriYukle(true);
            btnGeriYukle.Enabled = true;
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            FormKayit fk = new FormKayit(true);
            fk.Show();
        }

        private int getSelectedID(DataGridView data)
        {
            if (data.CurrentRow !=null)
            {
                int selectID = Convert.ToInt32(data.CurrentRow.Cells[0].Value);
                return selectID;
            }
            else
            {
                return -1;
            }
           
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataKullanıcılar);
            if (selectedID != -1)
            {
                var selectedUser = HelperBorsaKullanici.getRecordbyID(selectedID);
                FormKisiGuncelle fkb = new FormKisiGuncelle(selectedUser);
                fkb.Show();
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız..");
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataKullanıcılar);
            if (selectedID != -1)
            {
                int index = dataKullanıcılar.CurrentRow.Index;
                dataKullanıcılar.Rows.RemoveAt(index);
                var durum = HelperBorsaKullanici.UserDeleted(selectedID, true) ;
                HelperBorsaKullaniciIslem.IslemDeleted(selectedID, true);
                if (durum)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi..");
                }
                else
                {
                    MessageBox.Show("Silme sırasında bir hata oluştu!!");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız..");
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataKullanıcılar);
            if (selectedID != -1)
            {
                int index = dataKullanıcılar.CurrentRow.Index;
                dataKullanıcılar.Rows.RemoveAt(index);
                var durum = HelperBorsaKullanici.UserDeleted(selectedID, false);
                if (durum)
                {
                    MessageBox.Show("Kullanıcı başarıyla aktif edildi..");
                }
                else
                {
                    MessageBox.Show("Aktif etme sırasında bir hata oluştu!!");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız..");
            }
        }

        private void btnBorsaEkle_Click(object sender, EventArgs e)
        {
            FormBorsaKayit fbk = new FormBorsaKayit();
            fbk.Show();
        }

        private void btnBorsaSil_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataBorsa);
            if (selectedID != -1)
            {
                int index = dataBorsa.CurrentRow.Index;
                dataBorsa.Rows.RemoveAt(index);
                var durum = HelperBorsa.BorsaDeleted(selectedID, true);
                if (durum)
                {
                    MessageBox.Show("Borsa başarıyla kaldırıldı..");
                }
                else
                {
                    MessageBox.Show("Kaldırma sırasında bir hata oluştu!!");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız..");
            }
        }

        private void btnBorsaAktif_Click(object sender, EventArgs e)
        {
            btnBorsaGeriYukle.Enabled = false;
            BorsaYukle(false);
        }

        private void btnBorsaSilinen_Click(object sender, EventArgs e)
        {
            btnBorsaGeriYukle.Enabled = true;
            BorsaYukle(true);
        }

        private void btnBorsaGeriYukle_Click(object sender, EventArgs e)
        {
            int selectedID = getSelectedID(dataBorsa);
            if (selectedID != -1)
            {
                int index = dataBorsa.CurrentRow.Index;
                dataBorsa.Rows.RemoveAt(index);
                var durum = HelperBorsa.BorsaDeleted(selectedID, false);
                if (durum)
                {
                    MessageBox.Show("Borsa başarıyla geri eklendi..");
                }
                else
                {
                    MessageBox.Show("Geri ekleme sırasında bir hata oluştu!!");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız..");
            }
        }

        private void btnIslemAktif_Click(object sender, EventArgs e)
        {
            BorsaIslemYukle(false);
        }

        private void btnIslemPasif_Click(object sender, EventArgs e)
        {
            BorsaIslemYukle(true);
        }

        private void btnKullaniciAktif_Click(object sender, EventArgs e)
        {
            KullaniciIslemYukle(false);
        }

        private void btnKullaniciPasif_Click(object sender, EventArgs e)
        {
            KullaniciIslemYukle(true);
        }

        private void dtpBas_ValueChanged(object sender, EventArgs e)
        {
            dtpBit.MinDate = dtpBas.Value;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var basla = dtpBas.Value;
            var bit = dtpBit.Value;
            TarihliIslemler(basla, bit);
        }
        
        private void TarihliIslemler(DateTime bas, DateTime son)
        {
            dataKullaniciIslem.Rows.Clear();
            var islemList = HelperBorsaKullaniciIslem.getAllRecords();

            foreach (var i in islemList)
            {
                if (i.isDeleted == false)
                {
                    if (i.Tarih >= bas && i.Tarih <= son)
                    {
                        int satir = dataKullaniciIslem.Rows.Add();
                        dataKullaniciIslem.Rows[satir].Cells[0].Value = i.KullaniciIslemID;
                        dataKullaniciIslem.Rows[satir].Cells[1].Value = i.KullaniciID;
                        dataKullaniciIslem.Rows[satir].Cells[2].Value = i.Borsa.Adi;
                        dataKullaniciIslem.Rows[satir].Cells[3].Value = i.Miktar;
                        dataKullaniciIslem.Rows[satir].Cells[4].Value = i.Tarih;
                    }
                }
            }
        }

        private void btnGor_Click(object sender, EventArgs e)
        {
            dataBorsaIslem.Rows.Clear();
            var islemSecim = Convert.ToInt32(cmbIslem.SelectedValue);
            var islemList = HelperBorsaIslem.getAllRecordsbyID(islemSecim);
            foreach (var item in islemList)
            {
                int satir = dataBorsaIslem.Rows.Add();
                dataBorsaIslem.Rows[satir].Cells[0].Value = item.BorsaID;
                dataBorsaIslem.Rows[satir].Cells[1].Value = item.Borsa.Adi;
                dataBorsaIslem.Rows[satir].Cells[2].Value = item.Alis;
                dataBorsaIslem.Rows[satir].Cells[3].Value = item.Satis;
                dataBorsaIslem.Rows[satir].Cells[4].Value = item.Degisim;
                dataBorsaIslem.Rows[satir].Cells[5].Value = item.Tarih;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ComboBoxDoldur();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDoldur();
        }
    }
}
