using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace OrtakProje
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }
        public static string gelenVeri = "";

        SqlConnection baglantiT = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                
                btn18.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn18.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
               
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn18.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn18.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn18.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn18.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn18.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn18.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn18.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn18.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn18.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn18.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn18.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn18.Text);
                btn18.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn18.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn18.Text);
                ListeGuncelle();
            }



        }

        private void tabYetiskin_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                    if (maskedTC.Text != "" && dateRandevu.Text != "" && maskedSaat.Text != "")
                    {
                        baglantiT.Open();
                        SqlCommand komutt = new SqlCommand("select HastaAdSoyad from Randevu where TC=@tc and RandevuSaati=@saat ", baglantiT);
                        komutt.Parameters.AddWithValue("@tc", maskedTC.Text);
                        //komutt.Parameters.AddWithValue("@tarih", maskedTarih.Text);
                        komutt.Parameters.AddWithValue("@saat", maskedSaat.Text);
                        SqlDataReader rdd = komutt.ExecuteReader();
                        while (rdd.Read()) // ?
                        {
                            textAdSoyad.Text = rdd["HastaAdSoyad"].ToString();
                        }
                        baglantiT.Close();
                        eskiHaleGetir();

                    }
                    else
                    {

                        MessageBox.Show("Lütfen TC kimlik no ve Randevu tarihini ve saatini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
  
            
            

            catch
            {
                MessageBox.Show("Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void eskiHaleGetir()
        {

            btn11.Enabled = true;
            btn11.BackColor = Color.Transparent;
            btn12.Enabled = true;
            btn12.BackColor = Color.Transparent;
            btn13.Enabled = true;
            btn13.BackColor = Color.Transparent;
            btn14.Enabled = true;
            btn14.BackColor = Color.Transparent;
            btn15.Enabled = true;
            btn15.BackColor = Color.Transparent;
            btn16.Enabled = true;
            btn16.BackColor = Color.Transparent;
            btn17.Enabled = true;
            btn17.BackColor = Color.Transparent;
            btn18.Enabled = true;
            btn18.BackColor = Color.Transparent;
            btn21.Enabled = true;
            btn21.BackColor = Color.Transparent;
            btn23.Enabled = true;
            btn23.BackColor = Color.Transparent;
            btn24.Enabled = true;
            btn24.BackColor = Color.Transparent;
            btn25.Enabled = true;
            btn25.BackColor = Color.Transparent;
            btn26.Enabled = true;
            btn26.BackColor = Color.Transparent;
            btn27.Enabled = true;
            btn27.BackColor = Color.Transparent;
            btn28.Enabled = true;
            btn28.BackColor = Color.Transparent;
            btn22.Enabled = true;
            btn22.BackColor = Color.Transparent;
            btn31.Enabled = true;
            btn31.BackColor = Color.Transparent;
            btn32.Enabled = true;
            btn32.BackColor = Color.Transparent;
            btn33.Enabled = true;
            btn32.BackColor = Color.Transparent;
            btn34.Enabled = true;
            btn34.BackColor = Color.Transparent;
            btn35.Enabled = true;
            btn35.BackColor = Color.Transparent;
            btn36.Enabled = true;
            btn36.BackColor = Color.Transparent;
            btn37.Enabled = true;
            btn37.BackColor = Color.Transparent;
            btn38.Enabled = true;
            btn38.BackColor = Color.Transparent;
            btn41.Enabled = true;
            btn41.BackColor = Color.Transparent;
            btn42.Enabled = true;
            btn42.BackColor = Color.Transparent;
            btn43.Enabled = true;
            btn43.BackColor = Color.Transparent;
            btn44.Enabled = true;
            btn44.BackColor = Color.Transparent;
            btn45.Enabled = true;
            btn45.BackColor = Color.Transparent;
            btn46.Enabled = true;
            btn46.BackColor = Color.Transparent;
            btn47.Enabled = true;
            btn47.BackColor = Color.Transparent;
            btn48.Enabled = true;
            btn48.BackColor = Color.Transparent;
            btn51.Enabled = true;
            btn51.BackColor = Color.Transparent;
            btn52.Enabled = true;
            btn52.BackColor = Color.Transparent;
            btn53.Enabled = true;
            btn53.BackColor = Color.Transparent;
            btn54.Enabled = true;
            btn54.BackColor = Color.Transparent;
            btn55.Enabled = true;
            btn55.BackColor = Color.Transparent;
            btn61.Enabled = true;
            btn61.BackColor = Color.Transparent;
            btn62.Enabled = true;
            btn62.BackColor = Color.Transparent;
            btn63.Enabled = true;
            btn63.BackColor = Color.Transparent;
            btn64.Enabled = true;
            btn64.BackColor = Color.Transparent;
            btn65.Enabled = true;
            btn65.BackColor = Color.Transparent;
            btn71.Enabled = true;
            btn71.BackColor = Color.Transparent;
            btn72.Enabled = true;
            btn72.BackColor = Color.Transparent;
            btn73.Enabled = true;
            btn73.BackColor = Color.Transparent;
            btn74.Enabled = true;
            btn74.BackColor = Color.Transparent;
            btn75.Enabled = true;
            btn75.BackColor = Color.Transparent;
            btn81.Enabled = true;
            btn81.BackColor = Color.Transparent;
            btn82.Enabled = true;
            btn82.BackColor = Color.Transparent;
            btn83.Enabled = true;
            btn83.BackColor = Color.Transparent;
            btn84.Enabled = true;
            btn84.BackColor = Color.Transparent;
            btn85.Enabled = true;
            btn85.BackColor = Color.Transparent;

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                baglantiT.Open();
                string a = "a";
                SqlCommand guncelle = new SqlCommand("update Fiyat set cekim=@cekim,dolgu=@dolgu,kanal=@kanal,bakim=@bakim,implant=@implant,protez=@protez,ortodonti=@ortodonti,diseti=@diseti  where ucretId=@id", baglantiT);


                guncelle.Parameters.AddWithValue("@id", a);
                guncelle.Parameters.AddWithValue("@cekim", textCekimFiyat.Text);
                guncelle.Parameters.AddWithValue("@dolgu", textDolguFiyat.Text);
                guncelle.Parameters.AddWithValue("@kanal", textKanalFiyat.Text);
                guncelle.Parameters.AddWithValue("@bakim", textKanalFiyat.Text);
                guncelle.Parameters.AddWithValue("@implant", textImplantFiyat.Text);
                guncelle.Parameters.AddWithValue("@protez", textProtezFiyat.Text);
                guncelle.Parameters.AddWithValue("@ortodonti", textOrtodontiFiyat.Text);
                guncelle.Parameters.AddWithValue("@diseti", textDisEtiFiyat.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Fiyat Güncellemeler Başarılı.", "Fiyat Güncellemesi");


                baglantiT.Close();
            }
            catch
            {
                MessageBox.Show("Guncellenemedi!", "Fiyat Güncelleme Hatası");
            }



        }

        private void Tedavi_Load(object sender, EventArgs e) //form geldiginde var olan fiyatları verir
        {

            baglantiT.Open();
            string a = "a";
            SqlCommand yazdir = new SqlCommand("select * from Fiyat where ucretId=@id", baglantiT);
            yazdir.Parameters.AddWithValue("@id", a);
            SqlDataReader oku = yazdir.ExecuteReader();
            while (oku.Read())
            {
                textCekimFiyat.Text = oku["cekim"].ToString();
                textDolguFiyat.Text = oku["dolgu"].ToString();
                textKanalFiyat.Text = oku["kanal"].ToString();
                textBakimFiyat.Text = oku["bakim"].ToString();
                textImplantFiyat.Text = oku["implant"].ToString();
                textProtezFiyat.Text = oku["protez"].ToString();
                textOrtodontiFiyat.Text = oku["ortodonti"].ToString();
                textDisEtiFiyat.Text = oku["diseti"].ToString();


            }
            baglantiT.Close();

            //baglantiT.Open();
            //SqlCommand yansit = new SqlCommand("select * from Tedavi where Tc=@tc",baglantiT);
            //yansit.Parameters.AddWithValue("@tc", maskedTC.Text);
            //SqlDataAdapter  adp = new SqlDataAdapter(yansit);
            //DataTable dt = new DataTable();
            //adp.Fill(dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    listTedavi.Items.Add(dt.Rows[i]["tc"].ToString());
            //    listTedavi.Items[i].SubItems.Add(dt.Rows[i]["AdSoyad"].ToString());
            //    listTedavi.Items[i].SubItems.Add(dt.Rows[i]["RandevuTarihi"].ToString());
            //    listTedavi.Items[i].SubItems.Add(dt.Rows[i]["Fiyat"].ToString());
            //    listTedavi.Items[i].SubItems.Add(dt.Rows[i]["Islem"].ToString());

            //}
            //baglantiT.Close();


        }

        private void radioCekim_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void VeritabaniEkle(int fiyat,string islem)
        {
            if (textAdSoyad.Text != "")
            {


            baglantiT.Open();
            SqlCommand komut = new SqlCommand("insert into Tedavi (TC, Adsoyad,RandevuTarihi, Fiyat, Islem) values (@tc,@h,@date,@tl,@islem)", baglantiT);
            komut.Parameters.AddWithValue("@tc", maskedTC.Text);
            komut.Parameters.AddWithValue("@h",textAdSoyad.Text);
            komut.Parameters.AddWithValue("@date",dateRandevu.Value);
            komut.Parameters.AddWithValue("@tl",fiyat);
            komut.Parameters.AddWithValue("@islem",islem);
            komut.ExecuteNonQuery();
            MessageBox.Show("Tedavi Eklendi!", "Tedavi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglantiT.Close();
            }
            else
            {
                MessageBox.Show("Böyle Bir Hasta Randevusu Bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void ListeGuncelle()
        {
            listTedavi.Items.Clear();
            baglantiT.Open();
            SqlCommand yansit = new SqlCommand("select * from Tedavi where Tc=@tc", baglantiT);
            yansit.Parameters.AddWithValue("@tc", maskedTC.Text);
            SqlDataAdapter adp = new SqlDataAdapter(yansit);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listTedavi.Items.Add(dt.Rows[i]["tc"].ToString());
                listTedavi.Items[i].SubItems.Add(dt.Rows[i]["AdSoyad"].ToString());
                listTedavi.Items[i].SubItems.Add(dt.Rows[i]["RandevuTarihi"].ToString());
                listTedavi.Items[i].SubItems.Add(dt.Rows[i]["Fiyat"].ToString());
                listTedavi.Items[i].SubItems.Add(dt.Rows[i]["Islem"].ToString());

            }
            baglantiT.Close();
        }

        public int countC = 0;
        public int countD = 0;
        public int countK = 0;
        public int countI = 0;
        public int countP = 0;
        public int countO = 0;
        public int countB = 0;
        public int tutar = 0;
        private void btn11_Click(object sender, EventArgs e)
        {
 

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn11.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text),radioCekim.Text+" "+ btn11.Text);
                ListeGuncelle();
            }

            if(radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn11.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn11.Text);
                ListeGuncelle();

            }

            if(radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn11.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn11.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn11.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn11.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn11.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn11.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn11.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn11.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn11.Text);
                btn11.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn11.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn11.Text);
                ListeGuncelle();
            }



        }

        private void btn12_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn12.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn12.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn12.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn12.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn12.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn12.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn12.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn12.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn12.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn12.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn12.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn12.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn12.Text);
                btn12.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn12.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn12.Text);
                ListeGuncelle();
            }



        }

        private void btn13_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn13.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn13.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn13.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn13.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn13.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn13.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn13.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn13.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn13.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn13.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn13.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn13.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn13.Text);
                btn13.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn13.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn13.Text);
                ListeGuncelle();
            }


        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               //listIslem.Items.Add(radioCekim.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn14.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn14.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn14.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn14.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn14.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn14.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn14.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn14.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn14.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn14.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn14.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn14.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn14.Text);
                btn14.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn14.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn14.Text);
                ListeGuncelle();
            }


        }

        private void btn15_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn15.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn15.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn15.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn15.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn15.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn15.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn15.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn15.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn15.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn15.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn15.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn15.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn15.Text);
                btn15.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn15.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn15.Text);
                ListeGuncelle();
            }



        }

        private void btn16_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn16.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn16.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn16.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn16.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn16.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn16.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn16.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn16.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn16.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn16.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn16.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn16.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn16.Text);
                btn16.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn16.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn16.Text);
                ListeGuncelle();
            }


        }

        private void btn17_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn17.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn17.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn17.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn17.Text);
                ListeGuncelle();

            }

            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn17.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn17.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn17.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn17.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn17.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn17.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn17.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn17.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn17.Text);
                btn17.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn17.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn17.Text);
                ListeGuncelle();
            }


        }

        private void btn21_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn21.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn21.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn21.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn21.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn21.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn21.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn21.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn21.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn21.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn21.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn21.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn21.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn21.Text);
                btn21.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn21.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn21.Text);
                ListeGuncelle();
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn22.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn22.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn22.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn22.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn22.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn22.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn22.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn22.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn22.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn22.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn22.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn22.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn22.Text);
                btn22.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn22.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn22.Text);
                ListeGuncelle();
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn23.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn23.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn23.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn23.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
               // listIslem.Items.Add(radioKanal.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn23.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn23.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn23.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn23.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn23.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn23.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn23.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn23.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn23.Text);
                btn23.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn23.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn23.Text);
                ListeGuncelle();
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn24.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn24.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn24.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn24.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              // listIslem.Items.Add(radioKanal.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn24.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn24.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn24.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn24.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn24.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn24.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn24.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn24.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn24.Text);
                btn24.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn24.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn24.Text);
                ListeGuncelle();
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn25.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn25.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn25.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn25.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
               // listIslem.Items.Add(radioKanal.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn25.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn25.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn25.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn25.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn25.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn25.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn25.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn25.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn25.Text);
                btn25.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn25.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn25.Text);
                ListeGuncelle();
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn26.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn26.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn26.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn26.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn26.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn26.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn26.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn26.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn26.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn26.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn26.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn26.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn26.Text);
                btn26.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn26.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn26.Text);
                ListeGuncelle();
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn27.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn27.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn27.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn27.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
               // listIslem.Items.Add(radioKanal.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn27.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn27.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn27.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn27.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn27.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn27.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn27.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn27.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
                //listIslem.Items.Add(radioImplant.Text + " " + btn27.Text);
                btn27.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn27.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn27.Text);
                ListeGuncelle();
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
                //listIslem.Items.Add(radioCekim.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn28.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn28.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn28.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn28.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
                //listIslem.Items.Add(radioKanal.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn28.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn28.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn28.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn28.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn28.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn28.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn28.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn28.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn28.Text);
                btn28.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn28.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn28.Text);
                ListeGuncelle();
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                    //listIslem.Items.Add(radioCekim.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn31.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn31.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                    //listIslem.Items.Add(radioDolgu.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn31.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn31.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                    //listIslem.Items.Add(radioKanal.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn31.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn31.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                   // listIslem.Items.Add(radioProtez.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn31.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn31.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                   // listIslem.Items.Add(radioBakım.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn31.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn31.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                    //listIslem.Items.Add(radioOrtodonti.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn31.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn31.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                   // listIslem.Items.Add(radioImplant.Text + " " + btn31.Text);
                    btn31.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn31.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn31.Text);
                    ListeGuncelle();
                }
          }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn32.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn32.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
                //listIslem.Items.Add(radioDolgu.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn32.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn32.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn32.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn32.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
                //listIslem.Items.Add(radioProtez.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn32.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn32.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
                //listIslem.Items.Add(radioBakım.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn32.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn32.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
                //listIslem.Items.Add(radioOrtodonti.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn32.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textOrtodonti.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn32.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
              //  listIslem.Items.Add(radioImplant.Text + " " + btn32.Text);
                btn32.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn32.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn32.Text);
                ListeGuncelle();
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn33.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn33.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn33.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn33.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn33.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn33.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
              //  listIslem.Items.Add(radioProtez.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn33.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn33.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
              //  listIslem.Items.Add(radioBakım.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn33.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn33.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
              //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn33.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn33.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
              //  listIslem.Items.Add(radioImplant.Text + " " + btn33.Text);
                btn33.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn33.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn33.Text);
                ListeGuncelle();
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn34.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn34.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn34.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn34.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn34.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn34.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
              //  listIslem.Items.Add(radioProtez.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn34.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn34.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
              //  listIslem.Items.Add(radioBakım.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn34.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn34.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
               // listIslem.Items.Add(radioOrtodonti.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn34.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn34.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn34.Text);
                btn34.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn34.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn34.Text);
                ListeGuncelle();
            }

        }

        private void btn35_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn35.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn35.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
               // listIslem.Items.Add(radioDolgu.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn35.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn35.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn35.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn35.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
              //  listIslem.Items.Add(radioProtez.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn35.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn35.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
              //  listIslem.Items.Add(radioBakım.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn35.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn35.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
             //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn35.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn35.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
              //  listIslem.Items.Add(radioImplant.Text + " " + btn35.Text);
                btn35.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn35.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn35.Text);
                ListeGuncelle();
            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn36.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn36.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn36.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn36.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn36.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn36.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
             //   listIslem.Items.Add(radioProtez.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn36.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn36.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
              //  listIslem.Items.Add(radioBakım.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn36.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn36.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
              //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn36.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn36.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
              //  listIslem.Items.Add(radioImplant.Text + " " + btn36.Text);
                btn36.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn36.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn36.Text);
                ListeGuncelle();
            }
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn37.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn37.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn37.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn37.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn37.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn37.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
               // listIslem.Items.Add(radioProtez.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn37.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn37.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
               // listIslem.Items.Add(radioBakım.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn37.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn37.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
              //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn37.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn37.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
               // listIslem.Items.Add(radioImplant.Text + " " + btn37.Text);
                btn37.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn37.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn37.Text);
                ListeGuncelle();
            }
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
               // listIslem.Items.Add(radioCekim.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn38.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn38.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
            //   listIslem.Items.Add(radioDolgu.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn38.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn38.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn38.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn38.Text);
                ListeGuncelle();
            }

            if (radioProtez.Checked == true)
            {
             //   listIslem.Items.Add(radioProtez.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                btn38.Enabled = false;
                countP++;
                textProtez.Text = countP.ToString();
                tutar += Convert.ToInt32(textProtezFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn38.Text);
                ListeGuncelle();
            }
            if (radioBakım.Checked == true)
            {
             //   listIslem.Items.Add(radioBakım.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                btn38.Enabled = false;
                countB++;
                textBakim.Text = countB.ToString();
                tutar += Convert.ToInt32(textBakimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn38.Text);
                ListeGuncelle();
            }
            if (radioOrtodonti.Checked == true)
            {
             //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                btn38.Enabled = false;
                countO++;
                textOrtodonti.Text = countO.ToString();
                tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn38.Text);
                ListeGuncelle();
            }
            if (radioImplant.Checked == true)
            {
             //   listIslem.Items.Add(radioImplant.Text + " " + btn38.Text);
                btn38.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                btn38.Enabled = false;
                countI++;
                textImplant.Text = countI.ToString();
                tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn38.Text);
                ListeGuncelle();
            }
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                //    listIslem.Items.Add(radioCekim.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn41.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn41.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                 //   listIslem.Items.Add(radioDolgu.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn41.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn41.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                 //   listIslem.Items.Add(radioKanal.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn41.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn41.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                 //   listIslem.Items.Add(radioProtez.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn41.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn41.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                 //   listIslem.Items.Add(radioBakım.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn41.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn41.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                 //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn41.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn41.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                  //  listIslem.Items.Add(radioImplant.Text + " " + btn41.Text);
                    btn41.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn41.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn41.Text);
                    ListeGuncelle();
                }
            

        }

        private void btn42_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                  //  listIslem.Items.Add(radioCekim.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn42.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn42.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                   // listIslem.Items.Add(radioDolgu.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn42.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn42.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                  //  listIslem.Items.Add(radioKanal.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn42.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn42.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                   // listIslem.Items.Add(radioProtez.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn42.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn42.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                  //  listIslem.Items.Add(radioBakım.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn42.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn42.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                 //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn42.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn42.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                 //   listIslem.Items.Add(radioImplant.Text + " " + btn42.Text);
                    btn42.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn42.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn42.Text);
                    ListeGuncelle();
                }
            
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                 //   listIslem.Items.Add(radioCekim.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn43.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn43.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                 //   listIslem.Items.Add(radioDolgu.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn43.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn43.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                 //   listIslem.Items.Add(radioKanal.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn43.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn43.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                  //  listIslem.Items.Add(radioProtez.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn43.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn43.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                  //  listIslem.Items.Add(radioBakım.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn43.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn43.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                  //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn43.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn43.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                  //  listIslem.Items.Add(radioImplant.Text + " " + btn43.Text);
                    btn43.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn43.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn43.Text);
                    ListeGuncelle();
                }
            


        }

        private void btn44_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                  //  listIslem.Items.Add(radioCekim.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn44.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn44.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                  //  listIslem.Items.Add(radioDolgu.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn44.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn44.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                 //   listIslem.Items.Add(radioKanal.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn44.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn44.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                 //   listIslem.Items.Add(radioProtez.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn44.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn44.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                  //  listIslem.Items.Add(radioBakım.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn44.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn44.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                  //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn44.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn44.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                 //   listIslem.Items.Add(radioImplant.Text + " " + btn44.Text);
                    btn44.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn44.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn44.Text);
                    ListeGuncelle();
                }
            
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                  //  listIslem.Items.Add(radioCekim.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn45.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn45.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                 //   listIslem.Items.Add(radioDolgu.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn45.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn45.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                //    listIslem.Items.Add(radioKanal.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn45.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn45.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                //    listIslem.Items.Add(radioProtez.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn45.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn45.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                 //   listIslem.Items.Add(radioBakım.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn45.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn45.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                 //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn45.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn45.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                 //   listIslem.Items.Add(radioImplant.Text + " " + btn45.Text);
                    btn45.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn45.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn45.Text);
                    ListeGuncelle();
                }
            
        }

        private void btn46_Click(object sender, EventArgs e)
        {
              if (radioCekim.Checked == true)
                {
                 //   listIslem.Items.Add(radioCekim.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn46.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn46.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                 //   listIslem.Items.Add(radioDolgu.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn46.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn46.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                 //   listIslem.Items.Add(radioKanal.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn46.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn46.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                 //   listIslem.Items.Add(radioProtez.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn46.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn46.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                 //   listIslem.Items.Add(radioBakım.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn46.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn46.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                 //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn46.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += Convert.ToInt32(textOrtodontiFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn46.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                 //   listIslem.Items.Add(radioImplant.Text + " " + btn46.Text);
                    btn46.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn46.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn46.Text);
                    ListeGuncelle();
                }
            

        }

        private void btn47_Click(object sender, EventArgs e)
        {
           
                if (radioCekim.Checked == true)
                {
                  //  listIslem.Items.Add(radioCekim.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn47.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn47.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                   // listIslem.Items.Add(radioDolgu.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn47.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn47.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                 //   listIslem.Items.Add(radioKanal.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn47.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn47.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                  //  listIslem.Items.Add(radioProtez.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn47.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn47.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                 //   listIslem.Items.Add(radioBakım.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn47.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn47.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                  //  listIslem.Items.Add(radioOrtodonti.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn47.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += (Convert.ToInt32(textOrtodontiFiyat.Text));
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn47.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                  //  listIslem.Items.Add(radioImplant.Text + " " + btn47.Text);
                    btn47.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn47.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn47.Text);
                    ListeGuncelle();
                }
            


        }

        private void btn48_Click(object sender, EventArgs e)
        {
            
                if (radioCekim.Checked == true)
                {
                  //  listIslem.Items.Add(radioCekim.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                    btn48.Enabled = false;
                    countC++;
                    textCekim.Text = countC.ToString();
                    tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn48.Text);
                    ListeGuncelle();
                }

                if (radioDolgu.Checked == true)
                {
                  //  listIslem.Items.Add(radioDolgu.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn48.Enabled = false;
                    countD++;
                    textDolgu.Text = countD.ToString();
                    tutar += Convert.ToInt32(textDolguFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn48.Text);
                    ListeGuncelle();

                }
                if (radioKanal.Checked == true)
                {
                  //  listIslem.Items.Add(radioKanal.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                    btn48.Enabled = false;
                    countK++;
                    textKanal.Text = countK.ToString();
                    tutar += Convert.ToInt32(textKanalFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn48.Text);
                    ListeGuncelle();
                }

                if (radioProtez.Checked == true)
                {
                 //   listIslem.Items.Add(radioProtez.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(192, 255, 128);
                    btn48.Enabled = false;
                    countP++;
                    textProtez.Text = countP.ToString();
                    tutar += Convert.ToInt32(textProtezFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textProtezFiyat.Text), radioProtez.Text + " " + btn48.Text);
                    ListeGuncelle();
                }
                if (radioBakım.Checked == true)
                {
                 //   listIslem.Items.Add(radioBakım.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    btn48.Enabled = false;
                    countB++;
                    textBakim.Text = countB.ToString();
                    tutar += Convert.ToInt32(textBakimFiyat.Text);
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textBakimFiyat.Text), radioBakım.Text + " " + btn48.Text);
                    ListeGuncelle();
                }
                if (radioOrtodonti.Checked == true)
                {
                 //   listIslem.Items.Add(radioOrtodonti.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    btn48.Enabled = false;
                    countO++;
                    textOrtodonti.Text = countO.ToString();
                    tutar += (Convert.ToInt32(textOrtodontiFiyat.Text));
                    textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textOrtodontiFiyat.Text), radioOrtodonti.Text + " " + btn48.Text);
                    ListeGuncelle();
                }
                if (radioImplant.Checked == true)
                {
                 //   listIslem.Items.Add(radioImplant.Text + " " + btn48.Text);
                    btn48.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
                    btn48.Enabled = false;
                    countI++;
                    textImplant.Text = countI.ToString();
                    tutar += Convert.ToInt32(textImplantFiyat.Text);
                textTutar.Text = tutar.ToString();
                    VeritabaniEkle(Convert.ToInt32(textImplantFiyat.Text), radioImplant.Text + " " + btn48.Text);
                    ListeGuncelle();
                }
            
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn51.Text);
                btn51.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn51.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn51.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn51.Text);
                btn51.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn51.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn51.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn51.Text);
                btn51.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn51.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn51.Text);
                ListeGuncelle();
            }

        }

        private void btn52_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn52.Text);
                btn52.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn52.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn52.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn52.Text);
                btn52.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn52.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn52.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn52.Text);
                btn52.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn52.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn52.Text);
                ListeGuncelle();
            }
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn53.Text);
                btn53.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn53.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn53.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn53.Text);
                btn53.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn53.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn53.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn53.Text);
                btn53.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn53.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn53.Text);
                ListeGuncelle();
            }
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn54.Text);
                btn54.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn54.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn54.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn54.Text);
                btn54.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn54.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn54.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn54.Text);
                btn54.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn54.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn54.Text);
                ListeGuncelle();
            }
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn55.Text);
                btn55.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn55.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn55.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn55.Text);
                btn55.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn55.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn55.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn55.Text);
                btn55.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn55.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn55.Text);
                ListeGuncelle();
            }

        }

        private void btn61_Click(object sender, EventArgs e)
        {

            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn61.Text);
                btn61.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn61.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn61.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn61.Text);
                btn61.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn61.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn61.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn61.Text);
                btn61.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn61.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn61.Text);
                ListeGuncelle();
            }
        }

        private void btn62_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn62.Text);
                btn62.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn62.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn62.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn62.Text);
                btn62.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn62.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn62.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn62.Text);
                btn62.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn62.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn62.Text);
                ListeGuncelle();
            }
        }

        private void btn63_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn63.Text);
                btn63.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn63.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn63.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn63.Text);
                btn63.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn63.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn63.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn63.Text);
                btn63.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn63.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn63.Text);
                ListeGuncelle();
            }
        }

        private void btn64_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn64.Text);
                btn64.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn64.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn64.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn64.Text);
                btn64.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn64.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn64.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn64.Text);
                btn64.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn64.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn64.Text);
                ListeGuncelle();
            }
        }

        private void btn65_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn65.Text);
                btn65.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn65.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn65.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn65.Text);
                btn65.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn65.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn65.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn65.Text);
                btn65.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn65.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn65.Text);
                ListeGuncelle();
            }
        }

        private void btn71_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn71.Text);
                btn71.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn71.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn71.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn71.Text);
                btn71.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn71.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn71.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
              //  listIslem.Items.Add(radioKanal.Text + " " + btn71.Text);
                btn71.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn71.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn71.Text);
                ListeGuncelle();
            }
        }

        private void btn72_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn72.Text);
                btn72.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn72.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn72.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn72.Text);
                btn72.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn72.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn72.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn72.Text);
                btn72.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn72.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn72.Text);
                ListeGuncelle();
            }
        }

        private void btn73_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn73.Text);
                btn73.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn73.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn73.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn73.Text);
                btn73.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn73.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn73.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn73.Text);
                btn73.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn73.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn73.Text);
                ListeGuncelle();
            }
        }

        private void btn74_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn74.Text);
                btn74.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn74.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn74.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn74.Text);
                btn74.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn74.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn74.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn74.Text);
                btn74.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn74.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn74.Text);
                ListeGuncelle();
            }

        }

        private void btn75_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn75.Text);
                btn75.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn75.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn75.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn75.Text);
                btn75.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn75.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn75.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn75.Text);
                btn75.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn75.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn75.Text);
                ListeGuncelle();
            }
        }

        private void btn81_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn81.Text);
                btn81.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn81.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn81.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
             //   listIslem.Items.Add(radioDolgu.Text + " " + btn81.Text);
                btn81.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn81.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn81.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn81.Text);
                btn81.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn81.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn81.Text);
                ListeGuncelle();
            }
        }

        private void btn82_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn82.Text);
                btn82.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn82.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn82.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn82.Text);
                btn82.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn82.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn82.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn82.Text);
                btn82.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn82.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn82.Text);
                ListeGuncelle();
            }

        }

        private void btn83_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
              //  listIslem.Items.Add(radioCekim.Text + " " + btn83.Text);
                btn83.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn83.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn83.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
              //  listIslem.Items.Add(radioDolgu.Text + " " + btn83.Text);
                btn83.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn83.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn83.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn83.Text);
                btn83.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn83.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn83.Text);
                ListeGuncelle();
            }
        
    }

        private void btn84_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
            //    listIslem.Items.Add(radioCekim.Text + " " + btn84.Text);
                btn84.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn84.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn84.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
            //    listIslem.Items.Add(radioDolgu.Text + " " + btn84.Text);
                btn84.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn84.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn84.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn84.Text);
                btn84.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn84.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn84.Text);
                ListeGuncelle();
            }
        }

        private void btn85_Click(object sender, EventArgs e)
        {
            if (radioCekim.Checked == true)
            {
             //   listIslem.Items.Add(radioCekim.Text + " " + btn85.Text);
                btn85.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                btn85.Enabled = false;
                countC++;
                textCekim.Text = countC.ToString();
                //textTutar.Text = (countC * Convert.ToInt32(textCekimFiyat.Text)).ToString();
                tutar +=  Convert.ToInt32(textCekimFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textCekimFiyat.Text), radioCekim.Text + " " + btn85.Text);
                ListeGuncelle();
            }

            if (radioDolgu.Checked == true)
            {
            //    listIslem.Items.Add(radioDolgu.Text + " " + btn85.Text);
                btn85.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                btn85.Enabled = false;
                countD++;
                textDolgu.Text = countD.ToString();
                tutar += Convert.ToInt32(textDolguFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textDolguFiyat.Text), radioDolgu.Text + " " + btn85.Text);
                ListeGuncelle();

            }
            if (radioKanal.Checked == true)
            {
             //   listIslem.Items.Add(radioKanal.Text + " " + btn85.Text);
                btn85.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btn85.Enabled = false;
                countK++;
                textKanal.Text = countK.ToString();
                tutar += Convert.ToInt32(textKanalFiyat.Text);
                textTutar.Text = tutar.ToString();
                VeritabaniEkle(Convert.ToInt32(textKanalFiyat.Text), radioKanal.Text + " " + btn85.Text);
                ListeGuncelle();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisEti_Click(object sender, EventArgs e)
        {

            textDisEti.Text = Convert.ToString(1);
            tutar += (1 * Convert.ToInt32(textDisEtiFiyat.Text));
            textTutar.Text = tutar.ToString();
            VeritabaniEkle(Convert.ToInt32(textDisEtiFiyat.Text), btnDisEti.Text);
            ListeGuncelle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(maskedTC.Text!="" && textAdSoyad.Text!="" && textTutar.Text!="" && dateRandevu.Value != null)
            {
                baglantiT.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into Tutar (Tutar,TC,AdSoyad,Tarih) values (@tl,@tc,@ad,@tarih)", baglantiT);
                sqlCommand.Parameters.AddWithValue("@tl", textTutar.Text);
                sqlCommand.Parameters.AddWithValue("@tc", maskedTC.Text);
                sqlCommand.Parameters.AddWithValue("@ad", textAdSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@tarih", dateRandevu.Value);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tutar Kasaya Yollandı", "Onay",MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglantiT.Close();
            }

            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}

