namespace OrtakProje
{
    partial class DoktorRandevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevu));
            this.label11 = new System.Windows.Forms.Label();
            this.comboDoktorDktr = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBransDktr = new System.Windows.Forms.ComboBox();
            this.comboDktrSaat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateDktr = new System.Windows.Forms.DateTimePicker();
            this.btnDktrKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(74, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Doktor";
            // 
            // comboDoktorDktr
            // 
            this.comboDoktorDktr.FormattingEnabled = true;
            this.comboDoktorDktr.Location = new System.Drawing.Point(163, 110);
            this.comboDoktorDktr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDoktorDktr.Name = "comboDoktorDktr";
            this.comboDoktorDktr.Size = new System.Drawing.Size(225, 29);
            this.comboDoktorDktr.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(74, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Branş";
            // 
            // comboBransDktr
            // 
            this.comboBransDktr.FormattingEnabled = true;
            this.comboBransDktr.Location = new System.Drawing.Point(163, 59);
            this.comboBransDktr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBransDktr.Name = "comboBransDktr";
            this.comboBransDktr.Size = new System.Drawing.Size(225, 29);
            this.comboBransDktr.TabIndex = 28;
            this.comboBransDktr.SelectedIndexChanged += new System.EventHandler(this.comboBransDktr_SelectedIndexChanged);
            // 
            // comboDktrSaat
            // 
            this.comboDktrSaat.FormattingEnabled = true;
            this.comboDktrSaat.ItemHeight = 21;
            this.comboDktrSaat.Location = new System.Drawing.Point(163, 222);
            this.comboDktrSaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDktrSaat.Name = "comboDktrSaat";
            this.comboDktrSaat.Size = new System.Drawing.Size(225, 29);
            this.comboDktrSaat.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(74, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Saat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(74, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tarih";
            // 
            // dateDktr
            // 
            this.dateDktr.Location = new System.Drawing.Point(163, 166);
            this.dateDktr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDktr.Name = "dateDktr";
            this.dateDktr.Size = new System.Drawing.Size(225, 28);
            this.dateDktr.TabIndex = 31;
            // 
            // btnDktrKaydet
            // 
            this.btnDktrKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDktrKaydet.Location = new System.Drawing.Point(163, 275);
            this.btnDktrKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDktrKaydet.Name = "btnDktrKaydet";
            this.btnDktrKaydet.Size = new System.Drawing.Size(226, 61);
            this.btnDktrKaydet.TabIndex = 30;
            this.btnDktrKaydet.Text = "Kaydet";
            this.btnDktrKaydet.UseVisualStyleBackColor = true;
            this.btnDktrKaydet.Click += new System.EventHandler(this.btnDktrKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // DoktorRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboDoktorDktr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBransDktr);
            this.Controls.Add(this.comboDktrSaat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateDktr);
            this.Controls.Add(this.btnDktrKaydet);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoktorRandevu";
            this.Text = "DoktorRandevu";
            this.Load += new System.EventHandler(this.DoktorRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboDoktorDktr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBransDktr;
        private System.Windows.Forms.ComboBox comboDktrSaat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateDktr;
        private System.Windows.Forms.Button btnDktrKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}