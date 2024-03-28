namespace OrtakProje
{
    partial class Randevu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHepsi = new System.Windows.Forms.TabPage();
            this.btnHepsi = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textArama = new System.Windows.Forms.TextBox();
            this.RandHepsi = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Had = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ortakProjeDataSet = new OrtakProje.OrtakProjeDataSet();
            this.ortakProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSaat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDoktor = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnDktrRandevu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBrans = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabHepsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ortakProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortakProjeDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHepsi);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHepsi
            // 
            this.tabHepsi.Controls.Add(this.btnHepsi);
            this.tabHepsi.Controls.Add(this.btnYenile);
            this.tabHepsi.Controls.Add(this.label7);
            this.tabHepsi.Controls.Add(this.textArama);
            this.tabHepsi.Controls.Add(this.RandHepsi);
            this.tabHepsi.Location = new System.Drawing.Point(4, 24);
            this.tabHepsi.Name = "tabHepsi";
            this.tabHepsi.Padding = new System.Windows.Forms.Padding(3);
            this.tabHepsi.Size = new System.Drawing.Size(873, 529);
            this.tabHepsi.TabIndex = 1;
            this.tabHepsi.Text = "Hepsi";
            this.tabHepsi.UseVisualStyleBackColor = true;
            // 
            // btnHepsi
            // 
            this.btnHepsi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsi.Location = new System.Drawing.Point(478, 13);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(105, 36);
            this.btnHepsi.TabIndex = 34;
            this.btnHepsi.Text = "Hepsini Sırala";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(367, 13);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(105, 36);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Bul";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Arama Anahtarı:";
            // 
            // textArama
            // 
            this.textArama.BackColor = System.Drawing.Color.Fuchsia;
            this.textArama.Location = new System.Drawing.Point(163, 13);
            this.textArama.Multiline = true;
            this.textArama.Name = "textArama";
            this.textArama.Size = new System.Drawing.Size(183, 36);
            this.textArama.TabIndex = 1;
            // 
            // RandHepsi
            // 
            this.RandHepsi.BackColor = System.Drawing.Color.YellowGreen;
            this.RandHepsi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.TCNO,
            this.Had,
            this.Dad,
            this.rt,
            this.rs,
            this.dr});
            this.RandHepsi.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RandHepsi.FullRowSelect = true;
            this.RandHepsi.GridLines = true;
            this.RandHepsi.HideSelection = false;
            this.RandHepsi.Location = new System.Drawing.Point(3, 55);
            this.RandHepsi.Name = "RandHepsi";
            this.RandHepsi.Size = new System.Drawing.Size(864, 248);
            this.RandHepsi.TabIndex = 1;
            this.RandHepsi.UseCompatibleStateImageBehavior = false;
            this.RandHepsi.View = System.Windows.Forms.View.Details;
            this.RandHepsi.SelectedIndexChanged += new System.EventHandler(this.RandHepsi_SelectedIndexChanged);
            this.RandHepsi.DoubleClick += new System.EventHandler(this.RandHepsi_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "İd";
            // 
            // TCNO
            // 
            this.TCNO.Text = "T.C.";
            this.TCNO.Width = 140;
            // 
            // Had
            // 
            this.Had.Text = "Hasta";
            this.Had.Width = 133;
            // 
            // Dad
            // 
            this.Dad.Text = "Doktor";
            this.Dad.Width = 148;
            // 
            // rt
            // 
            this.rt.Text = "Randevu Tarih";
            this.rt.Width = 105;
            // 
            // rs
            // 
            this.rs.Text = "Randevu Saat";
            this.rs.Width = 152;
            // 
            // dr
            // 
            this.dr.Text = "Randevu Durum";
            this.dr.Width = 189;
            // 
            // ortakProjeDataSet
            // 
            this.ortakProjeDataSet.DataSetName = "OrtakProjeDataSet";
            this.ortakProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ortakProjeDataSetBindingSource
            // 
            this.ortakProjeDataSetBindingSource.DataSource = this.ortakProjeDataSet;
            this.ortakProjeDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSaat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textDoktor);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnDktrRandevu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTC);
            this.groupBox1.Controls.Add(this.textAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBrans);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Oluştur";
            // 
            // comboSaat
            // 
            this.comboSaat.FormattingEnabled = true;
            this.comboSaat.Location = new System.Drawing.Point(321, 130);
            this.comboSaat.Name = "comboSaat";
            this.comboSaat.Size = new System.Drawing.Size(200, 29);
            this.comboSaat.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Randevu Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(115, 27);
            this.textId.Multiline = true;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(200, 28);
            this.textId.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Doktor";
            // 
            // textDoktor
            // 
            this.textDoktor.FormattingEnabled = true;
            this.textDoktor.Location = new System.Drawing.Point(115, 169);
            this.textDoktor.Name = "textDoktor";
            this.textDoktor.Size = new System.Drawing.Size(200, 29);
            this.textDoktor.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(689, 119);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 58);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(537, 119);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 58);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(689, 32);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 58);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnDktrRandevu
            // 
            this.btnDktrRandevu.Location = new System.Drawing.Point(537, 32);
            this.btnDktrRandevu.Name = "btnDktrRandevu";
            this.btnDktrRandevu.Size = new System.Drawing.Size(133, 58);
            this.btnDktrRandevu.TabIndex = 11;
            this.btnDktrRandevu.Text = "Doktor Randevu";
            this.btnDktrRandevu.UseVisualStyleBackColor = true;
            this.btnDktrRandevu.Click += new System.EventHandler(this.btnDktrRandevu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarih";
            // 
            // dateTarih
            // 
            this.dateTarih.Location = new System.Drawing.Point(322, 62);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(200, 28);
            this.dateTarih.TabIndex = 9;
            this.dateTarih.ValueChanged += new System.EventHandler(this.dateTarih_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Branş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(115, 62);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(200, 28);
            this.maskedTC.TabIndex = 5;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(115, 96);
            this.textAdSoyad.Multiline = true;
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(200, 28);
            this.textAdSoyad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No";
            // 
            // textBrans
            // 
            this.textBrans.FormattingEnabled = true;
            this.textBrans.Location = new System.Drawing.Point(115, 130);
            this.textBrans.Name = "textBrans";
            this.textBrans.Size = new System.Drawing.Size(200, 29);
            this.textBrans.TabIndex = 7;
            this.textBrans.SelectedIndexChanged += new System.EventHandler(this.textBrans_SelectedIndexChanged);
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHepsi.ResumeLayout(false);
            this.tabHepsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ortakProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortakProjeDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHepsi;
        private System.Windows.Forms.ListView RandHepsi;
        private OrtakProjeDataSet ortakProjeDataSet;
        private System.Windows.Forms.BindingSource ortakProjeDataSetBindingSource;
        private System.Windows.Forms.Button btnHepsi;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textArama;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader TCNO;
        private System.Windows.Forms.ColumnHeader Had;
        private System.Windows.Forms.ColumnHeader Dad;
        private System.Windows.Forms.ColumnHeader rt;
        private System.Windows.Forms.ColumnHeader rs;
        private System.Windows.Forms.ColumnHeader dr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSaat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox textDoktor;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnDktrRandevu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textBrans;
    }
}