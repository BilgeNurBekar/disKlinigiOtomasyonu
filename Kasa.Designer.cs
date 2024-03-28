namespace OrtakProje
{
    partial class Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.dateKasa = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTahsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textTutar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(193, 62);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(152, 28);
            this.maskedTC.TabIndex = 5;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // dateKasa
            // 
            this.dateKasa.Location = new System.Drawing.Point(193, 107);
            this.dateKasa.Name = "dateKasa";
            this.dateKasa.Size = new System.Drawing.Size(152, 28);
            this.dateKasa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "TC No";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(256, 141);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(89, 35);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTahsil
            // 
            this.btnTahsil.Location = new System.Drawing.Point(256, 226);
            this.btnTahsil.Name = "btnTahsil";
            this.btnTahsil.Size = new System.Drawing.Size(89, 36);
            this.btnTahsil.TabIndex = 11;
            this.btnTahsil.Text = "Tahsil Et";
            this.btnTahsil.UseVisualStyleBackColor = true;
            this.btnTahsil.Click += new System.EventHandler(this.btnTahsil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tutar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textTutar
            // 
            this.textTutar.Location = new System.Drawing.Point(193, 183);
            this.textTutar.Margin = new System.Windows.Forms.Padding(4);
            this.textTutar.Name = "textTutar";
            this.textTutar.Size = new System.Drawing.Size(152, 28);
            this.textTutar.TabIndex = 13;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 367);
            this.Controls.Add(this.textTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTahsil);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateKasa);
            this.Controls.Add(this.maskedTC);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kasa";
            this.Text = "Kasa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.DateTimePicker dateKasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTahsil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTutar;
    }
}