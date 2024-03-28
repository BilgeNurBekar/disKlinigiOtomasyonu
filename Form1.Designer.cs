namespace OrtakProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnTedavi = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.tabHastaKart = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.maskedTel = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textAdrr = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabHastaList = new System.Windows.Forms.TabPage();
            this.HastaList = new System.Windows.Forms.ListView();
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TedaviDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.radioBtnDevam = new System.Windows.Forms.RadioButton();
            this.radioBtnDevamD = new System.Windows.Forms.RadioButton();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimeGuncel = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTCGuncel = new System.Windows.Forms.MaskedTextBox();
            this.textAdGuncel = new System.Windows.Forms.TextBox();
            this.maskedTelGuncel = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textMailGuncel = new System.Windows.Forms.TextBox();
            this.textAdrrGuncel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioKadinGuncel = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.radioErkekGuncel = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHepsi = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.textArama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.altTab = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabHastaKart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabHastaList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.altTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.btnTedavi);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnRandevu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 90);
            this.panel1.TabIndex = 4;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(871, 58);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(62, 21);
            this.lblKullanici.TabIndex = 12;
            this.lblKullanici.Text = "label24";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(172, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 18);
            this.label22.TabIndex = 11;
            this.label22.Text = "Tedavi";
            // 
            // btnTedavi
            // 
            this.btnTedavi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTedavi.BackgroundImage")));
            this.btnTedavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTedavi.Location = new System.Drawing.Point(165, 0);
            this.btnTedavi.Name = "btnTedavi";
            this.btnTedavi.Size = new System.Drawing.Size(63, 67);
            this.btnTedavi.TabIndex = 10;
            this.btnTedavi.UseVisualStyleBackColor = true;
            this.btnTedavi.Click += new System.EventHandler(this.btnTedavi_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.Location = new System.Drawing.Point(344, 71);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 18);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "Yönetici Paneli";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.Location = new System.Drawing.Point(360, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(63, 67);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(262, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Çıkış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Randevu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kasa";
            // 
            // btnKasa
            // 
            this.btnKasa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.BackgroundImage")));
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasa.Location = new System.Drawing.Point(18, 0);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(63, 67);
            this.btnKasa.TabIndex = 0;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(251, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(63, 67);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRandevu.BackgroundImage")));
            this.btnRandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevu.Location = new System.Drawing.Point(96, 0);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(63, 67);
            this.btnRandevu.TabIndex = 1;
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // tabHastaKart
            // 
            this.tabHastaKart.Controls.Add(this.groupBox1);
            this.tabHastaKart.Location = new System.Drawing.Point(4, 24);
            this.tabHastaKart.Name = "tabHastaKart";
            this.tabHastaKart.Padding = new System.Windows.Forms.Padding(3);
            this.tabHastaKart.Size = new System.Drawing.Size(977, 644);
            this.tabHastaKart.TabIndex = 1;
            this.tabHastaKart.Text = "Hasta Kartı";
            this.tabHastaKart.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC No";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimeDogum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioBtnErkek);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radioBtnKadin);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.maskedTC);
            this.groupBox1.Controls.Add(this.textAdSoyad);
            this.groupBox1.Controls.Add(this.maskedTel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.textAdrr);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 361);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // dateTimeDogum
            // 
            this.dateTimeDogum.Location = new System.Drawing.Point(124, 83);
            this.dateTimeDogum.Name = "dateTimeDogum";
            this.dateTimeDogum.Size = new System.Drawing.Size(151, 26);
            this.dateTimeDogum.TabIndex = 17;
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.Location = new System.Drawing.Point(208, 123);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(67, 22);
            this.radioBtnErkek.TabIndex = 16;
            this.radioBtnErkek.TabStop = true;
            this.radioBtnErkek.Text = "Erkek";
            this.radioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Telefon";
            // 
            // radioBtnKadin
            // 
            this.radioBtnKadin.AutoSize = true;
            this.radioBtnKadin.Location = new System.Drawing.Point(124, 123);
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.Size = new System.Drawing.Size(66, 22);
            this.radioBtnKadin.TabIndex = 15;
            this.radioBtnKadin.TabStop = true;
            this.radioBtnKadin.Text = "Kadın";
            this.radioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(8, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cinsiyet";
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(124, 20);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(151, 26);
            this.maskedTC.TabIndex = 7;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(124, 55);
            this.textAdSoyad.Multiline = true;
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(151, 22);
            this.textAdSoyad.TabIndex = 8;
            // 
            // maskedTel
            // 
            this.maskedTel.Location = new System.Drawing.Point(124, 159);
            this.maskedTel.Mask = "(999) 000-0000";
            this.maskedTel.Name = "maskedTel";
            this.maskedTel.Size = new System.Drawing.Size(151, 26);
            this.maskedTel.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(8, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Doğum Tarihi";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(124, 204);
            this.textMail.Multiline = true;
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(151, 22);
            this.textMail.TabIndex = 10;
            // 
            // textAdrr
            // 
            this.textAdrr.Location = new System.Drawing.Point(124, 240);
            this.textAdrr.Multiline = true;
            this.textAdrr.Name = "textAdrr";
            this.textAdrr.Size = new System.Drawing.Size(329, 59);
            this.textAdrr.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnKaydet.Location = new System.Drawing.Point(620, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(216, 49);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "E- Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Adres";
            // 
            // tabHastaList
            // 
            this.tabHastaList.Controls.Add(this.HastaList);
            this.tabHastaList.Controls.Add(this.groupBox2);
            this.tabHastaList.Controls.Add(this.panel2);
            this.tabHastaList.Location = new System.Drawing.Point(4, 24);
            this.tabHastaList.Name = "tabHastaList";
            this.tabHastaList.Padding = new System.Windows.Forms.Padding(3);
            this.tabHastaList.Size = new System.Drawing.Size(977, 644);
            this.tabHastaList.TabIndex = 0;
            this.tabHastaList.Text = "Hasta Listesi";
            this.tabHastaList.UseVisualStyleBackColor = true;
            this.tabHastaList.Click += new System.EventHandler(this.tabHastaList_Click);
            // 
            // HastaList
            // 
            this.HastaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HastaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TC,
            this.AdSoyad,
            this.DogumTarihi,
            this.Cinsiyet,
            this.Telefon,
            this.Mail,
            this.Adres,
            this.TedaviDurumu});
            this.HastaList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HastaList.GridLines = true;
            this.HastaList.HideSelection = false;
            this.HastaList.Location = new System.Drawing.Point(0, 54);
            this.HastaList.Name = "HastaList";
            this.HastaList.Size = new System.Drawing.Size(977, 281);
            this.HastaList.TabIndex = 16;
            this.HastaList.UseCompatibleStateImageBehavior = false;
            this.HastaList.View = System.Windows.Forms.View.Details;
            this.HastaList.SelectedIndexChanged += new System.EventHandler(this.tabHastaList_Click);
            this.HastaList.DoubleClick += new System.EventHandler(this.HastaList_DoubleClick);
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 135;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "Ad Soyad";
            this.AdSoyad.Width = 152;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Text = "Doğum Tarihi";
            this.DogumTarihi.Width = 92;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Text = "Cinsiyet";
            this.Cinsiyet.Width = 70;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 117;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 104;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 182;
            // 
            // TedaviDurumu
            // 
            this.TedaviDurumu.Text = "Tedavi Durumu";
            this.TedaviDurumu.Width = 552;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.radioBtnDevam);
            this.groupBox2.Controls.Add(this.radioBtnDevamD);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dateTimeGuncel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.maskedTCGuncel);
            this.groupBox2.Controls.Add(this.textAdGuncel);
            this.groupBox2.Controls.Add(this.maskedTelGuncel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textMailGuncel);
            this.groupBox2.Controls.Add(this.textAdrrGuncel);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 319);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Güncelleme Ekranı";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(294, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 21);
            this.label21.TabIndex = 25;
            this.label21.Text = "Tedavi Durumu";
            // 
            // radioBtnDevam
            // 
            this.radioBtnDevam.AutoSize = true;
            this.radioBtnDevam.Location = new System.Drawing.Point(422, 40);
            this.radioBtnDevam.Name = "radioBtnDevam";
            this.radioBtnDevam.Size = new System.Drawing.Size(120, 22);
            this.radioBtnDevam.TabIndex = 12;
            this.radioBtnDevam.TabStop = true;
            this.radioBtnDevam.Text = "Devam Ediyor";
            this.radioBtnDevam.UseVisualStyleBackColor = true;
            // 
            // radioBtnDevamD
            // 
            this.radioBtnDevamD.AutoSize = true;
            this.radioBtnDevamD.Location = new System.Drawing.Point(422, 68);
            this.radioBtnDevamD.Name = "radioBtnDevamD";
            this.radioBtnDevamD.Size = new System.Drawing.Size(131, 22);
            this.radioBtnDevamD.TabIndex = 13;
            this.radioBtnDevamD.TabStop = true;
            this.radioBtnDevamD.Text = "Devam Etmiyor";
            this.radioBtnDevamD.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(745, 96);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 49);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(745, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 49);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(564, 159);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 49);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(4, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 19;
            this.label20.Text = "Ad Soyad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(4, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 21);
            this.label19.TabIndex = 18;
            this.label19.Text = "TC No";
            // 
            // dateTimeGuncel
            // 
            this.dateTimeGuncel.Location = new System.Drawing.Point(124, 83);
            this.dateTimeGuncel.Name = "dateTimeGuncel";
            this.dateTimeGuncel.Size = new System.Drawing.Size(151, 26);
            this.dateTimeGuncel.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(10, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "Telefon";
            // 
            // maskedTCGuncel
            // 
            this.maskedTCGuncel.Location = new System.Drawing.Point(124, 20);
            this.maskedTCGuncel.Mask = "00000000000";
            this.maskedTCGuncel.Name = "maskedTCGuncel";
            this.maskedTCGuncel.Size = new System.Drawing.Size(151, 26);
            this.maskedTCGuncel.TabIndex = 4;
            this.maskedTCGuncel.ValidatingType = typeof(int);
            // 
            // textAdGuncel
            // 
            this.textAdGuncel.Location = new System.Drawing.Point(124, 55);
            this.textAdGuncel.Multiline = true;
            this.textAdGuncel.Name = "textAdGuncel";
            this.textAdGuncel.Size = new System.Drawing.Size(151, 22);
            this.textAdGuncel.TabIndex = 5;
            // 
            // maskedTelGuncel
            // 
            this.maskedTelGuncel.Location = new System.Drawing.Point(124, 159);
            this.maskedTelGuncel.Mask = "(999) 000-0000";
            this.maskedTelGuncel.Name = "maskedTelGuncel";
            this.maskedTelGuncel.Size = new System.Drawing.Size(151, 26);
            this.maskedTelGuncel.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "Doğum Tarihi";
            // 
            // textMailGuncel
            // 
            this.textMailGuncel.Location = new System.Drawing.Point(124, 204);
            this.textMailGuncel.Multiline = true;
            this.textMailGuncel.Name = "textMailGuncel";
            this.textMailGuncel.Size = new System.Drawing.Size(151, 22);
            this.textMailGuncel.TabIndex = 10;
            // 
            // textAdrrGuncel
            // 
            this.textAdrrGuncel.Location = new System.Drawing.Point(124, 240);
            this.textAdrrGuncel.Multiline = true;
            this.textAdrrGuncel.Name = "textAdrrGuncel";
            this.textAdrrGuncel.Size = new System.Drawing.Size(329, 59);
            this.textAdrrGuncel.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(10, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "E- Mail";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(10, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 21);
            this.label18.TabIndex = 4;
            this.label18.Text = "Adres";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(564, 96);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(151, 49);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(287, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 88);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tedavi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioKadinGuncel);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.radioErkekGuncel);
            this.groupBox3.Location = new System.Drawing.Point(8, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 48);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // radioKadinGuncel
            // 
            this.radioKadinGuncel.AutoSize = true;
            this.radioKadinGuncel.Location = new System.Drawing.Point(116, 15);
            this.radioKadinGuncel.Name = "radioKadinGuncel";
            this.radioKadinGuncel.Size = new System.Drawing.Size(66, 22);
            this.radioKadinGuncel.TabIndex = 7;
            this.radioKadinGuncel.TabStop = true;
            this.radioKadinGuncel.Text = "Kadın";
            this.radioKadinGuncel.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(2, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cinsiyet";
            // 
            // radioErkekGuncel
            // 
            this.radioErkekGuncel.AutoSize = true;
            this.radioErkekGuncel.Location = new System.Drawing.Point(188, 15);
            this.radioErkekGuncel.Name = "radioErkekGuncel";
            this.radioErkekGuncel.Size = new System.Drawing.Size(67, 22);
            this.radioErkekGuncel.TabIndex = 8;
            this.radioErkekGuncel.TabStop = true;
            this.radioErkekGuncel.Text = "Erkek";
            this.radioErkekGuncel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHepsi);
            this.panel2.Controls.Add(this.btnYenile);
            this.panel2.Controls.Add(this.textArama);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 58);
            this.panel2.TabIndex = 0;
            // 
            // btnHepsi
            // 
            this.btnHepsi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsi.Location = new System.Drawing.Point(475, 12);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(105, 36);
            this.btnHepsi.TabIndex = 3;
            this.btnHepsi.Text = "Hepsini Sırala";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(353, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(105, 36);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Bul";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // textArama
            // 
            this.textArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textArama.Location = new System.Drawing.Point(143, 12);
            this.textArama.Multiline = true;
            this.textArama.Name = "textArama";
            this.textArama.Size = new System.Drawing.Size(183, 36);
            this.textArama.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arama Anahtarı:";
            // 
            // altTab
            // 
            this.altTab.Controls.Add(this.tabHastaList);
            this.altTab.Controls.Add(this.tabHastaKart);
            this.altTab.Location = new System.Drawing.Point(1, 92);
            this.altTab.Name = "altTab";
            this.altTab.SelectedIndex = 0;
            this.altTab.Size = new System.Drawing.Size(985, 672);
            this.altTab.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(986, 776);
            this.Controls.Add(this.altTab);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHastaKart.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabHastaList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.altTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TabPage tabHastaKart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeDogum;
        private System.Windows.Forms.RadioButton radioBtnErkek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textAdrr;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabHastaList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox textArama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl altTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeGuncel;
        private System.Windows.Forms.RadioButton radioErkekGuncel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioKadinGuncel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTCGuncel;
        private System.Windows.Forms.TextBox textAdGuncel;
        private System.Windows.Forms.MaskedTextBox maskedTelGuncel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textMailGuncel;
        private System.Windows.Forms.TextBox textAdrrGuncel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnTedavi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton radioBtnDevam;
        private System.Windows.Forms.RadioButton radioBtnDevamD;
        private System.Windows.Forms.ListView HastaList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader DogumTarihi;
        private System.Windows.Forms.ColumnHeader Cinsiyet;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader TedaviDurumu;
        private System.Windows.Forms.Button btnHepsi;
        private System.Windows.Forms.Label lblKullanici;
    }
}

