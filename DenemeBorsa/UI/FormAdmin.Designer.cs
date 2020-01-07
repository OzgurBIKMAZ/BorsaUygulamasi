namespace DenemeBorsa.UI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataKullanıcılar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiDuzenle = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataBorsa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBorsaGeriYukle = new System.Windows.Forms.Button();
            this.btnBorsaSilinen = new System.Windows.Forms.Button();
            this.btnBorsaAktif = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBorsaEkle = new System.Windows.Forms.Button();
            this.btnBorsaSil = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataBorsaIslem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnGor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataKullaniciIslem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnGoster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBas = new System.Windows.Forms.DateTimePicker();
            this.dtpBit = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKullanıcılar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorsa)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorsaIslem)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKullaniciIslem)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1257, 559);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataKullanıcılar);
            this.tabPage1.Controls.Add(this.panel12);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1249, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataKullanıcılar
            // 
            this.dataKullanıcılar.AllowUserToAddRows = false;
            this.dataKullanıcılar.AllowUserToDeleteRows = false;
            this.dataKullanıcılar.AllowUserToResizeColumns = false;
            this.dataKullanıcılar.AllowUserToResizeRows = false;
            this.dataKullanıcılar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKullanıcılar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKullanıcılar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataKullanıcılar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKullanıcılar.Location = new System.Drawing.Point(3, 43);
            this.dataKullanıcılar.Name = "dataKullanıcılar";
            this.dataKullanıcılar.ReadOnly = true;
            this.dataKullanıcılar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKullanıcılar.Size = new System.Drawing.Size(1133, 411);
            this.dataKullanıcılar.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 113.2995F;
            this.Column2.HeaderText = "Tur";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 113.2995F;
            this.Column3.HeaderText = "Kullanıcı Adı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 113.2995F;
            this.Column4.HeaderText = "Sifre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 113.2995F;
            this.Column5.HeaderText = "Kayıt Tarihi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1133, 40);
            this.panel12.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnGeriYukle);
            this.panel3.Controls.Add(this.btnDeleted);
            this.panel3.Controls.Add(this.btnActive);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1136, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 451);
            this.panel3.TabIndex = 3;
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriYukle.Image")));
            this.btnGeriYukle.Location = new System.Drawing.Point(16, 321);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(75, 66);
            this.btnGeriYukle.TabIndex = 6;
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleted.Image")));
            this.btnDeleted.Location = new System.Drawing.Point(16, 223);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(75, 66);
            this.btnDeleted.TabIndex = 2;
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnActive
            // 
            this.btnActive.Image = ((System.Drawing.Image)(resources.GetObject("btnActive.Image")));
            this.btnActive.Location = new System.Drawing.Point(16, 128);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(75, 66);
            this.btnActive.TabIndex = 1;
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnKisiSil);
            this.panel2.Controls.Add(this.btnKisiDuzenle);
            this.panel2.Controls.Add(this.btnKisiEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 73);
            this.panel2.TabIndex = 0;
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiSil.Image")));
            this.btnKisiSil.Location = new System.Drawing.Point(447, 3);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(75, 65);
            this.btnKisiSil.TabIndex = 5;
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnKisiDuzenle
            // 
            this.btnKisiDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiDuzenle.Image")));
            this.btnKisiDuzenle.Location = new System.Drawing.Point(263, 3);
            this.btnKisiDuzenle.Name = "btnKisiDuzenle";
            this.btnKisiDuzenle.Size = new System.Drawing.Size(75, 65);
            this.btnKisiDuzenle.TabIndex = 4;
            this.btnKisiDuzenle.UseVisualStyleBackColor = true;
            this.btnKisiDuzenle.Click += new System.EventHandler(this.btnKisiDuzenle_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiEkle.Image")));
            this.btnKisiEkle.Location = new System.Drawing.Point(30, 3);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 65);
            this.btnKisiEkle.TabIndex = 1;
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataBorsa);
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1249, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borsa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataBorsa
            // 
            this.dataBorsa.AllowUserToAddRows = false;
            this.dataBorsa.AllowUserToDeleteRows = false;
            this.dataBorsa.AllowUserToResizeColumns = false;
            this.dataBorsa.AllowUserToResizeRows = false;
            this.dataBorsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBorsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorsa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column8});
            this.dataBorsa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBorsa.Location = new System.Drawing.Point(3, 43);
            this.dataBorsa.Name = "dataBorsa";
            this.dataBorsa.ReadOnly = true;
            this.dataBorsa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBorsa.Size = new System.Drawing.Size(1133, 401);
            this.dataBorsa.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 50F;
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tur";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Borsa Adı";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Eklenme Tarihi";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1133, 40);
            this.panel11.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.btnBorsaGeriYukle);
            this.panel6.Controls.Add(this.btnBorsaSilinen);
            this.panel6.Controls.Add(this.btnBorsaAktif);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1136, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 441);
            this.panel6.TabIndex = 6;
            // 
            // btnBorsaGeriYukle
            // 
            this.btnBorsaGeriYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnBorsaGeriYukle.Image")));
            this.btnBorsaGeriYukle.Location = new System.Drawing.Point(18, 298);
            this.btnBorsaGeriYukle.Name = "btnBorsaGeriYukle";
            this.btnBorsaGeriYukle.Size = new System.Drawing.Size(75, 66);
            this.btnBorsaGeriYukle.TabIndex = 9;
            this.btnBorsaGeriYukle.UseVisualStyleBackColor = true;
            this.btnBorsaGeriYukle.Click += new System.EventHandler(this.btnBorsaGeriYukle_Click);
            // 
            // btnBorsaSilinen
            // 
            this.btnBorsaSilinen.Image = ((System.Drawing.Image)(resources.GetObject("btnBorsaSilinen.Image")));
            this.btnBorsaSilinen.Location = new System.Drawing.Point(18, 193);
            this.btnBorsaSilinen.Name = "btnBorsaSilinen";
            this.btnBorsaSilinen.Size = new System.Drawing.Size(75, 66);
            this.btnBorsaSilinen.TabIndex = 1;
            this.btnBorsaSilinen.UseVisualStyleBackColor = true;
            this.btnBorsaSilinen.Click += new System.EventHandler(this.btnBorsaSilinen_Click);
            // 
            // btnBorsaAktif
            // 
            this.btnBorsaAktif.Image = ((System.Drawing.Image)(resources.GetObject("btnBorsaAktif.Image")));
            this.btnBorsaAktif.Location = new System.Drawing.Point(18, 105);
            this.btnBorsaAktif.Name = "btnBorsaAktif";
            this.btnBorsaAktif.Size = new System.Drawing.Size(75, 66);
            this.btnBorsaAktif.TabIndex = 7;
            this.btnBorsaAktif.UseVisualStyleBackColor = true;
            this.btnBorsaAktif.Click += new System.EventHandler(this.btnBorsaAktif_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.btnBorsaEkle);
            this.panel7.Controls.Add(this.btnBorsaSil);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 444);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1243, 83);
            this.panel7.TabIndex = 5;
            // 
            // btnBorsaEkle
            // 
            this.btnBorsaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnBorsaEkle.Image")));
            this.btnBorsaEkle.Location = new System.Drawing.Point(25, 6);
            this.btnBorsaEkle.Name = "btnBorsaEkle";
            this.btnBorsaEkle.Size = new System.Drawing.Size(75, 66);
            this.btnBorsaEkle.TabIndex = 9;
            this.btnBorsaEkle.UseVisualStyleBackColor = true;
            this.btnBorsaEkle.Click += new System.EventHandler(this.btnBorsaEkle_Click);
            // 
            // btnBorsaSil
            // 
            this.btnBorsaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnBorsaSil.Image")));
            this.btnBorsaSil.Location = new System.Drawing.Point(192, 6);
            this.btnBorsaSil.Name = "btnBorsaSil";
            this.btnBorsaSil.Size = new System.Drawing.Size(75, 66);
            this.btnBorsaSil.TabIndex = 8;
            this.btnBorsaSil.UseVisualStyleBackColor = true;
            this.btnBorsaSil.Click += new System.EventHandler(this.btnBorsaSil_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataBorsaIslem);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1249, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Borsa İşlem";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataBorsaIslem
            // 
            this.dataBorsaIslem.AllowUserToAddRows = false;
            this.dataBorsaIslem.AllowUserToDeleteRows = false;
            this.dataBorsaIslem.AllowUserToResizeColumns = false;
            this.dataBorsaIslem.AllowUserToResizeRows = false;
            this.dataBorsaIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBorsaIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorsaIslem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.Column9,
            this.Column12});
            this.dataBorsaIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBorsaIslem.Location = new System.Drawing.Point(3, 43);
            this.dataBorsaIslem.Name = "dataBorsaIslem";
            this.dataBorsaIslem.ReadOnly = true;
            this.dataBorsaIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBorsaIslem.Size = new System.Drawing.Size(1133, 403);
            this.dataBorsaIslem.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 50F;
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Borsa Adı";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Alış (TL)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Satış (TL)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Değişim";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "İşlem Tarihi";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Controls.Add(this.btnGor);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1136, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 403);
            this.panel8.TabIndex = 15;
            // 
            // btnGor
            // 
            this.btnGor.Image = ((System.Drawing.Image)(resources.GetObject("btnGor.Image")));
            this.btnGor.Location = new System.Drawing.Point(21, 6);
            this.btnGor.Name = "btnGor";
            this.btnGor.Size = new System.Drawing.Size(75, 70);
            this.btnGor.TabIndex = 1;
            this.btnGor.UseVisualStyleBackColor = true;
            this.btnGor.Click += new System.EventHandler(this.btnGor_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnYenile);
            this.panel5.Controls.Add(this.cmbIslem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1243, 40);
            this.panel5.TabIndex = 14;
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(967, 5);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(55, 31);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(1028, 6);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(210, 28);
            this.cmbIslem.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 446);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1243, 81);
            this.panel9.TabIndex = 8;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataKullaniciIslem);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Controls.Add(this.panel10);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1249, 530);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kullanıcı İşlem";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataKullaniciIslem
            // 
            this.dataKullaniciIslem.AllowUserToAddRows = false;
            this.dataKullaniciIslem.AllowUserToDeleteRows = false;
            this.dataKullaniciIslem.AllowUserToResizeColumns = false;
            this.dataKullaniciIslem.AllowUserToResizeRows = false;
            this.dataKullaniciIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKullaniciIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKullaniciIslem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dataKullaniciIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKullaniciIslem.Location = new System.Drawing.Point(3, 43);
            this.dataKullaniciIslem.Name = "dataKullaniciIslem";
            this.dataKullaniciIslem.ReadOnly = true;
            this.dataKullaniciIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKullaniciIslem.Size = new System.Drawing.Size(1133, 404);
            this.dataKullaniciIslem.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.FillWeight = 50F;
            this.dataGridViewTextBoxColumn14.HeaderText = "ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Kullanıcı ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Borsa Adı";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Miktar";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1133, 80);
            this.panel4.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.btnGoster);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(1136, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(110, 484);
            this.panel10.TabIndex = 14;
            // 
            // btnGoster
            // 
            this.btnGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnGoster.Image")));
            this.btnGoster.Location = new System.Drawing.Point(16, 6);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(78, 69);
            this.btnGoster.TabIndex = 19;
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtpBas);
            this.panel1.Controls.Add(this.dtpBit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 40);
            this.panel1.TabIndex = 13;
            // 
            // dtpBas
            // 
            this.dtpBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBas.Location = new System.Drawing.Point(692, 8);
            this.dtpBas.Name = "dtpBas";
            this.dtpBas.Size = new System.Drawing.Size(236, 24);
            this.dtpBas.TabIndex = 0;
            this.dtpBas.ValueChanged += new System.EventHandler(this.dtpBas_ValueChanged);
            // 
            // dtpBit
            // 
            this.dtpBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBit.Location = new System.Drawing.Point(991, 8);
            this.dtpBit.Name = "dtpBit";
            this.dtpBit.Size = new System.Drawing.Size(236, 24);
            this.dtpBit.TabIndex = 18;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1257, 559);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKullanıcılar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBorsa)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBorsaIslem)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKullaniciIslem)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnBorsaSilinen;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataKullanıcılar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.DataGridView dataBorsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiDuzenle;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.Button btnBorsaGeriYukle;
        private System.Windows.Forms.Button btnBorsaAktif;
        private System.Windows.Forms.Button btnBorsaEkle;
        private System.Windows.Forms.Button btnBorsaSil;
        private System.Windows.Forms.DataGridView dataKullaniciIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DateTimePicker dtpBit;
        private System.Windows.Forms.DateTimePicker dtpBas;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGor;
        private System.Windows.Forms.DataGridView dataBorsaIslem;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnYenile;
    }
}