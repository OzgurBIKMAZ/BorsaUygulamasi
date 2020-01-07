using DenemeBorsa.DAL;
using DenemeBorsa.Entity;
using DenemeBorsa.Model;
using DenemeBorsa.UI;
using System;
using System.Collections;
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

namespace DenemeBorsa
{
    public partial class FormMenu : Form
    {
        int sayacMenu = 0;
        int userID;
        double userBakiye = 0;
        List<string[]> userCuzdanList = new List<string[]>();
        BorsaKullanici userLogin;
        List<Borsa> borsaList = HelperBorsa.getAllRecords(false);
        static Random r = new Random();
        public FormMenu(int id)
        {
            InitializeComponent();
            this.userID = id;
            timer1.Interval = 150;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            lblTarih.Text = DateTime.Now.ToString();
            userLogin = HelperBorsaKullanici.getRecordbyID(userID);
            lblUserName.Text = userLogin.KullaniciAdi;
            UserCheck(userID);
            BilgileriYukle(userLogin);
            ComboBoxDoldur();
            lblSifreTekrar.Visible = false;
            OnayKoduAl();
            rdbDoviz.Checked = true;
            MenkulDoldur();
            CuzdanGuncelle();
            timer1.Start();
        }

        private void TabBorsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOnay.Clear();
            txtBakiye.Clear();
            txtMenkulSat.Clear();
            txtMenkulTutar.Clear();
            mTxtTelefon.Text = userLogin.Telefon;
            txtMail.Text = userLogin.Email;
            txtAdres.Text = userLogin.Adres;
            BilgileriYukle(userLogin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayacMenu++;
            lblTarih.Text = DateTime.Now.ToString();
            DataGridDoldur(sayacMenu);
        }

        private void DataGridDoldur(int say)
        {
            if (say % 3 == 0)
            {
                dataCanli.Rows.Clear();

                foreach (var borsa in borsaList)
                {
                    if (borsa.BorsaID != 1)  // BorsaID-1 Nakit işlemleri 
                    {
                        var i = HelperBorsaIslem.getLastRecord(borsa.BorsaID);
                        if (i != null)
                        {
                            int satir = dataCanli.Rows.Add();
                            dataCanli.Rows[satir].Cells[0].Value = i.Borsa.Adi;
                            dataCanli.Rows[satir].Cells[1].Value = i.Alis;
                            dataCanli.Rows[satir].Cells[2].Value = i.Satis;
                            dataCanli.Rows[satir].Cells[3].Value = i.Degisim.ToString("0.0000");
                            dataCanli.Rows[satir].Cells[4].Value = i.Tarih.ToString("hh:mm");

                            if (i.BorsaID > 1 && i.BorsaID < 9)
                            {
                                DovizGuncelle(i);
                            }
                        }
                        
                    }
                }

            }
        }

        private void DovizGuncelle(BorsaIslemModel islem)
        {
            switch (islem.BorsaID)
            {
                case 2:
                    lblDolarAl.Text = islem.Alis.ToString("0.0000");
                    lblDolarSat.Text = islem.Satis.ToString("0.0000");
                    lblDolarArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblDolarArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblDolarArtis.ForeColor = Color.Red;
                    }
                    break;
                case 3:
                    lblEuroAl.Text = islem.Alis.ToString("0.0000");
                    lblEuroSat.Text = islem.Satis.ToString("0.0000");
                    lblEuroArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblEuroArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblEuroArtis.ForeColor = Color.Red;
                    }
                    break;
                case 4:
                    lblSterlinAl.Text = islem.Alis.ToString("0.0000");
                    lblSterlinSat.Text = islem.Satis.ToString("0.0000");
                    lblSterlinArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblSterlinArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblSterlinArtis.ForeColor = Color.Red;
                    }
                    break;
                case 5:
                    lblFrankAl.Text = islem.Alis.ToString("0.0000");
                    lblFrankSat.Text = islem.Satis.ToString("0.0000");
                    lblFrankArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblFrankArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblFrankArtis.ForeColor = Color.Red;
                    }
                    break;
                case 6:
                    lblYenAl.Text = islem.Alis.ToString("0.0000");
                    lblYenSat.Text = islem.Satis.ToString("0.0000");
                    lblYenArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblYenArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblYenArtis.ForeColor = Color.Red;
                    }
                    break;
                case 7:
                    lblAltinGrAl.Text = islem.Alis.ToString("0.0000");
                    lblAltinGrSat.Text = islem.Satis.ToString("0.0000");
                    lblAltinGrArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblAltinGrArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblAltinGrArtis.ForeColor = Color.Red;
                    }
                    break;
                case 8:
                    lblAltinCeyrekAl.Text = islem.Alis.ToString("0.0000");
                    lblAltinCeyrekSat.Text = islem.Satis.ToString("0.0000");
                    lblAltinCeyrekArtis.Text = islem.Degisim.ToString("0.0000");
                    if (islem.Degisim >= 0)
                    {
                        lblAltinCeyrekArtis.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblAltinCeyrekArtis.ForeColor = Color.Red;
                    }
                    break;

            }
        
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void UserCheck(int id)
        {
            if (id == 1)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
            //this.Close();

        }

        private void BilgileriYukle(BorsaKullanici login)
        {
            txtKullaniciAdi.Text = login.KullaniciAdi;
            txtAd.Text = login.Adi;
            txtSoyad.Text = login.Soyadi;
            mTxtTelefon.Text = login.Telefon;
            txtMail.Text = login.Email;
            txtAdres.Text = login.Adres;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            dataIslem.Rows.Clear();
            var islemSecim = Convert.ToInt32(cmbIslem.SelectedValue);
            var islemList = HelperBorsaIslem.getAllRecordsbyID(islemSecim);
            foreach (var item in islemList)
            {
                int satir = dataIslem.Rows.Add();
                dataIslem.Rows[satir].Cells[0].Value = item.Borsa.Adi;
                dataIslem.Rows[satir].Cells[1].Value = item.Alis;
                dataIslem.Rows[satir].Cells[2].Value = item.Satis;
                dataIslem.Rows[satir].Cells[3].Value = item.Degisim.ToString("0.0000");
                dataIslem.Rows[satir].Cells[4].Value = item.Tarih.ToString();
            }


        }

        private void ComboBoxDoldur()
        {
            var list = HelperBorsa.getAllRecords(false);
            cmbIslem.ValueMember = "BorsaID";
            cmbIslem.DisplayMember = "Adi";
            cmbIslem.DataSource = list;
        }

        private void BtnSifreDeğistir_Click(object sender, EventArgs e)
        {
            bool durumSifre = string.IsNullOrEmpty(txtSifreEski.Text) ||
                              string.IsNullOrEmpty(txtSifreYeni.Text) ||
                              string.IsNullOrEmpty(txtSifreYeniTekrar.Text);
            if (durumSifre)
            {
                MessageBox.Show("Şifre değişim için ilgili alanları doldurunuz..", "Giriş Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SifreDegistir(userLogin);
            }
           
        }
        
        private void SifreDegistir(BorsaKullanici user)
        {
            string sifreGirilen = txtSifreEski.Text;

            if (sifreGirilen.Equals(user.Sifre))
            {
                string sifreDegistir = txtSifreYeni.Text;
                string sifreTekrar = txtSifreYeniTekrar.Text;

                if (sifreDegistir.Equals(sifreTekrar))
                {
                    var sonuc = HelperBorsaKullanici.ChangePassword(userLogin, sifreDegistir);
                    if (sonuc)
                    {
                        MessageBox.Show("Şifre Başarıyla Değiştirildi!!!", "Şifre Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSifreEski.Clear();
                        txtSifreYeni.Clear();
                        txtSifreYeniTekrar.Clear();
                        lblSifreTekrar.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Hatası", "Database Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblSifreTekrar.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girişi Yaptınız!!!");
            }
        }

        private void BtnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            string telefon = mTxtTelefon.Text;
            string mail = txtMail.Text;
            string adres = txtAdres.Text;

            var durumGuncel = HelperBorsaKullanici.IletisimBilgileriGuncelle(userLogin, telefon, mail, adres);
            if (durumGuncel)
            {
                BilgileriYukle(userLogin);
                MessageBox.Show("Bilgiler Başarıyla Güncellendi..");
            }
            else
            {
                MessageBox.Show("Güncelleme Hatası");
            }
        }

        private void TabBorsa_TabIndexChanged(object sender, EventArgs e)
        {
            mTxtTelefon.Clear();
            txtMail.Clear();
            txtAdres.Clear();
            txtSifreEski.Clear();
            txtSifreYeni.Clear();
            txtSifreYeniTekrar.Clear();
            lblSifreTekrar.Visible = false;
        }

        private void BtnYukle_Click(object sender, EventArgs e)
        {
            if (txtOnay.Text.Equals(lblOnay.Text))
            {
                if (string.IsNullOrEmpty(txtBakiye.Text))
                {
                    MessageBox.Show("Bakiye Bilgisi Girmediniz!!", "Bakiye Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var durumBakiye = HelperBorsaKullaniciIslem.BakiyeEkle(userID, double.Parse(txtBakiye.Text), true);
                    if (durumBakiye)
                    {
                        MessageBox.Show("Bakiye Başarıyla Eklenmiştir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CuzdanDoldur();
                        BakiyeHesapla();
                        lblBakiye.Text = userBakiye.ToString("#,##0");
                    }
                    else
                    {
                        MessageBox.Show("Bakiye yükleme sırasında bir hata oluştu!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz onay kodu yanlış, tekrar deneyiniz.", "Onay Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnayKoduAl();
            }
        }

        private void BtnCuzdan_Click(object sender, EventArgs e)
        {           
            CuzdanGuncelle();
            
        }

        private void CuzdanGuncelle()
        {
            dataCuzdan.Rows.Clear();
            CuzdanDoldur();
            BakiyeHesapla();

            lblBakiye.Text = userBakiye.ToString("#,##0");
            foreach (string[] c in userCuzdanList)
            {
                int satir = dataCuzdan.Rows.Add();
                dataCuzdan.Rows[satir].Cells[0].Value = c[1];
                dataCuzdan.Rows[satir].Cells[1].Value = c[2];
                dataCuzdan.Rows[satir].Cells[2].Value = c[0];

            }
        }

        private void BakiyeHesapla()
        {
            double toplam = 0;
            var bakiyeList = HelperBorsaKullaniciIslem.getRecordsbyBorsaID(userID, 1);
            foreach (var b in bakiyeList)
            {
                if (b.CuzdanEkle)
                {
                    toplam += b.Miktar;
                }
                else
                {
                    toplam -= b.Miktar;
                }
                userBakiye = toplam;
            }
        }

        private void CuzdanDoldur()
        {
            userCuzdanList.Clear();
            var borsaList = HelperBorsa.getAllRecords(false);
            foreach (var b in borsaList)
            {
                double toplam = 0;
                var cuzdanList = HelperBorsaKullaniciIslem.getRecordsbyBorsaID(userID, b.BorsaID);
                foreach (var c in cuzdanList)
                {
                    if (c.CuzdanEkle)
                    {
                        toplam += c.Miktar;
                    }
                    else
                    {
                        toplam -= c.Miktar;
                    }

                }
                if (toplam > 0)
                {
                    string[] cuzdanDeger = { b.BorsaID.ToString(), b.Adi, toplam.ToString() };
                    userCuzdanList.Add(cuzdanDeger);
                }
                
            }
        }

        private void DtpOzetBas_ValueChanged(object sender, EventArgs e)
        {
            dtpOzetBit.MinDate = dtpOzetBas.Value;
        }

        private void BtnOzetAl_Click(object sender, EventArgs e)
        {
            dataHesapOzet.Rows.Clear();
            var hesapList = HelperBorsaKullaniciIslem.getAllRecordsbyID(userID);
            foreach (var h in hesapList)
            {
                if (h.Tarih >= dtpOzetBas.Value && h.Tarih <=dtpOzetBit.Value )
                {
                    int satir = dataHesapOzet.Rows.Add();
                    dataHesapOzet.Rows[satir].Cells[0].Value = (BorsaTur)h.Borsa.Tur;
                    dataHesapOzet.Rows[satir].Cells[1].Value = h.Borsa.Adi;
                    dataHesapOzet.Rows[satir].Cells[2].Value = h.Miktar;
                    dataHesapOzet.Rows[satir].Cells[3].Value = CuzdanDurumu(h.CuzdanEkle, h.BorsaID);
                    dataHesapOzet.Rows[satir].Cells[4].Value = h.Tarih;

                    if (h.CuzdanEkle)
                    {
                        dataHesapOzet.Rows[satir].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dataHesapOzet.Rows[satir].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }
                }
            }
        }

        private string CuzdanDurumu(bool deger, int id)
        {
            if (id==1)
            {
                return "Bakiye İşlemi";
            }
            else
            {
                if (deger)
                {
                    return "Alım";
                }
                else
                {
                    return "Satış";
                }

            }
            
        }

        private void OnayKoduAl()
        {
            var onay = r.Next(10000, 99999);
            lblOnay.Text = onay.ToString();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OnayKoduAl();
        }

        private void RadioButtonChanged(object sender, EventArgs e)
        {
            MenkulDoldur();
        }


        private void MenkulDoldur()
        {
            cmbMenkul.ValueMember = "BorsaID";
            cmbMenkul.DisplayMember = "Adi";

            if (rdbDoviz.Checked)
            {
                var listDoviz = HelperBorsa.gelAllRecordsbyTur(1);
                cmbMenkul.DataSource = listDoviz;

            }
            else if (rdbAltin.Checked)
            {
                var listAltin = HelperBorsa.gelAllRecordsbyTur(2);
                cmbMenkul.DataSource = listAltin;
            }
            else
            {
                var listHisse = HelperBorsa.gelAllRecordsbyTur(3);
                cmbMenkul.DataSource = listHisse;
            }

        }

        private void BtnAlim_Click(object sender, EventArgs e)
        {
            var alimID = Convert.ToInt32(cmbMenkul.SelectedValue);
            var islem = HelperBorsaIslem.getLastRecord(alimID);

            if (string.IsNullOrEmpty(txtMenkulTutar.Text))
            {
                MessageBox.Show("Tutar bilgisi girmediniz!!", "Tutar Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tutar = islem.Satis * int.Parse(txtMenkulTutar.Text);
                DialogResult result = MessageBox.Show($"{islem.Satis.ToString("0.0000")} birim fiyatından {cmbMenkul.Text} alımı yapıyorsunuz.\n" +
                    $"İşlem Tutarı: {tutar.ToString("0.0000")} Devam ediyor musunuz?",
                    "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (userBakiye >= tutar)
                    {
                        BorsaKullaniciIslem bki = new BorsaKullaniciIslem()
                        {
                            KullaniciID = userID,
                            BorsaID = islem.BorsaID,
                            Miktar = int.Parse(txtMenkulTutar.Text),
                            Tarih = DateTime.Now,
                            CuzdanEkle = true
                        };
                        var durumIslem = HelperBorsaKullaniciIslem.CUD(bki, EntityState.Added);
                        if (durumIslem.Item1)
                        {
                            HelperBorsaKullaniciIslem.BakiyeEkle(userID, tutar, false);
                            MessageBox.Show("işlem tamamlanmıştır");
                            CuzdanGuncelle();
                        }
                        else
                        {
                            MessageBox.Show("işlem sırasında bir hata meydana geldi");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bakiyeniz bu işlem için yetersiz!!\n" +
                            "İsterseniz bakiye yükleyerek işleme devam edebilir veya işlem tutarını değiştirebilirsiniz.",
                            "Bakiye Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void BtnSat_Click(object sender, EventArgs e)
        {
            if (dataCuzdan.CurrentRow == null)
            {
                MessageBox.Show("Herhangi bir menkul seçmediniz", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var index = dataCuzdan.CurrentRow.Index;
                var cuzdanID = Convert.ToInt32(dataCuzdan.Rows[index].Cells[2].Value);
                var islem = HelperBorsaIslem.getLastRecord(cuzdanID);

                if (string.IsNullOrEmpty(txtMenkulSat.Text))
                {
                    MessageBox.Show("Tutar bilgisi girmediniz!!", "Tutar Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var toplam = islem.Alis * int.Parse(txtMenkulSat.Text);
                    DialogResult result = MessageBox.Show($"{islem.Alis.ToString("0.0000")} birim fiyatından {dataCuzdan.Rows[index].Cells[0].Value} satışı yapıyorsunuz.\n" +
                        $"İşlem Tutarı: {toplam.ToString("0.0000")} Devam ediyor musunuz?",
                        "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        BorsaKullaniciIslem bki = new BorsaKullaniciIslem()
                        {
                            KullaniciID = userID,
                            BorsaID = islem.BorsaID,
                            Miktar = int.Parse(txtMenkulSat.Text),
                            Tarih = DateTime.Now,
                            CuzdanEkle = false
                        };
                        var durumIslem = HelperBorsaKullaniciIslem.CUD(bki, EntityState.Added);
                        if (durumIslem.Item1)
                        {
                            HelperBorsaKullaniciIslem.BakiyeEkle(userID, toplam, true);
                            MessageBox.Show("işlem tamamlanmıştır");
                            CuzdanGuncelle();
                        }
                        else
                        {
                            MessageBox.Show("işlem sırasında bir hata meydana geldi");
                        }
                    }
                }
            }
        }

        private void NoSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
