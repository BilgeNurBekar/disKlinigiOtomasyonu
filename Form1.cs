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

namespace OrtakProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True"); //veritabanı baglantisini yapar

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabHastaList_Click(object sender, EventArgs e)
        {

        }

        private void btnTedavi_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblKullanici.Text = Giris.kullanici.ToString();
            HastaList.Columns.Add("TC", 100);
            HastaList.Columns.Add("Ad Soyad", 180);
            HastaList.Columns.Add("Doğum Tarihi", 100);
            HastaList.Columns.Add("Cinsiyet", 80);
            HastaList.Columns.Add("Telefon", 150);
            HastaList.Columns.Add("Mail", 150);
            HastaList.Columns.Add("Adres", 150);
            HastaList.Columns.Add("Tedavi Durumu", 150);

            SqlCommand komut = new SqlCommand("select TC, adsoyad, dogumtarihi,cinsiyet,telefon,mail,adres, TedaviDurumu from HastaListesi", baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HastaList.Items.Add(dt.Rows[i]["tc"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["AdSoyad"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["DogumTarihi"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Cinsiyet"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Telefon"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Mail"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Adres"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["TedaviDurumu"].ToString());
            }


            SqlCommand komut2 = new SqlCommand("Select Kadi,Yonetici from Kullanici where Kadi=@Kadi and Yonetici=@Yonetici", baglanti);
            komut2.Parameters.AddWithValue("@Kadi", lblKullanici.Text);
            komut2.Parameters.AddWithValue("@Yonetici", true);
            baglanti.Open();
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                btnAdmin.Visible = true;
                lblAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
                lblAdmin.Visible = false;
            }
            baglanti.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTC.Text != "" && textAdSoyad.Text != "" && dateTimeDogum.Text != "" &&
                    maskedTel.Text != "" && textMail.Text != "" && textAdrr.Text != "" &&
                    ((radioBtnKadin.Checked == true) || (radioBtnErkek.Checked == true)))
                {
                    baglanti.Open();

                    SqlCommand tekrar = new SqlCommand("select count(*) from HastalarListesi where TC=@tc ", baglanti);
                    tekrar.Parameters.AddWithValue("@tc",maskedTC.Text);
                    //int sonuc = (int)tekrar.ExecuteScalar();
                    //if (sonuc == 0)
                    //{
                        string cinsiyet = "";
                        if (radioBtnErkek.Checked)
                            cinsiyet = radioBtnErkek.Text;
                        else if (radioBtnKadin.Checked)
                            cinsiyet = radioBtnKadin.Text;

                        SqlCommand komut = new SqlCommand("insert into HastaListesi(TC,AdSoyad,DogumTarihi,Cinsiyet,Telefon,Mail,Adres) values (@TC, @AdSoyad, @DogumTarihi, @Cinsiyet, @Telefon, @Mail,@Adres)", baglanti);


                        komut.Parameters.AddWithValue("@TC", maskedTC.Text);
                        komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
                        komut.Parameters.AddWithValue("@DogumTarihi", dateTimeDogum.Value);
                        komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@Telefon", maskedTel.Text);
                        komut.Parameters.AddWithValue("@Mail", textMail.Text);
                        komut.Parameters.AddWithValue("@Adres", textAdrr.Text);
                        komut.ExecuteNonQuery(); //sorguyu çalıştırır
                        baglanti.Close();
                        MessageBox.Show("Hasta kaydedildi.");
                    //}
                }
                else
                {
                    MessageBox.Show("Bu alanlar boş bırakılamaz \n Lütfen Boş alanları doldurun.");
                }
            }
            catch
            {
                MessageBox.Show("Hasta Kaydedilemedi.\n Bilgileri kontrol edip tekrar deneyin.");
                baglanti.Close();
            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            maskedTCGuncel.Text = "";
            textAdGuncel.Text = "";
            radioErkekGuncel.Checked = false;
            radioKadinGuncel.Checked = false;
            maskedTelGuncel.Text = "";
            textMailGuncel.Text = "";
            textAdrrGuncel.Text = "";
            radioBtnDevam.Checked = false;
            radioBtnDevamD.Checked = false;
            maskedTCGuncel.Focus(); //imleci maskedTcGuncel texitine getirir

        }

        private void HastaList_DoubleClick(object sender, EventArgs e) //bir hücreye 2 defa tıklandığında database verilerini araçlara taşır
        {
            // TC alanına çift tıklandığında satırın bilgilerini araçlara taşır.


            if (HastaList.SelectedItems[0].SubItems[3].Text == "Erkek")
                radioErkekGuncel.Checked = true;
            else if (HastaList.SelectedItems[0].SubItems[3].Text == "Kadın")
                radioKadinGuncel.Checked = true;
            maskedTCGuncel.Text = HastaList.SelectedItems[0].SubItems[0].Text; // seçilen satırın verisini tc maskedBox ına taşıdı.
            textAdGuncel.Text = HastaList.SelectedItems[0].SubItems[1].Text;
            dateTimeGuncel.Text = HastaList.SelectedItems[0].SubItems[2].Text;
            maskedTelGuncel.Text = HastaList.SelectedItems[0].SubItems[4].Text;
            textMailGuncel.Text = HastaList.SelectedItems[0].SubItems[5].Text;
            textAdrrGuncel.Text = HastaList.SelectedItems[0].SubItems[6].Text;
            if (HastaList.SelectedItems[0].SubItems[7].Text == "Devam Ediyor")
                radioBtnDevam.Checked = true;
            else if (HastaList.SelectedItems[0].SubItems[7].Text == "Devam Etmiyor")
                radioBtnDevamD.Checked = true;



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                string cinsiyet = "";
                string durum = "";


                SqlCommand guncelle = new SqlCommand("update HastaListesi set TC=@tc, Adsoyad= @adsoyad, DogumTarihi=@dogumTarihi, cinsiyet=@cinsiyet, Telefon= @telefon, Mail=@mail, Adres=@adres, TedaviDurumu=@durum where tc=@tc", baglanti);
                
                if (radioErkekGuncel.Checked) 
                {
                    cinsiyet = radioErkekGuncel.Text;
                }
                    
                else if (radioKadinGuncel.Checked)
                {
                    cinsiyet = radioKadinGuncel.Text;
                }
                 
                
                guncelle.Parameters.AddWithValue("@tc", maskedTCGuncel.Text);
                guncelle.Parameters.AddWithValue("@adsoyad", textAdGuncel.Text);
                guncelle.Parameters.AddWithValue("@dogumTarihi", dateTimeGuncel.Value);
                guncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                guncelle.Parameters.AddWithValue("@telefon", maskedTelGuncel.Text);
                guncelle.Parameters.AddWithValue("@mail", textMailGuncel.Text);
                guncelle.Parameters.AddWithValue("@adres", textAdrrGuncel.Text);
                if (radioBtnDevamD.Checked) 
                {
                    durum = radioBtnDevamD.Text;
                }
                    
                else if (radioBtnDevam.Checked)
                {
                    durum = radioBtnDevam.Text;
                }
                    
                guncelle.Parameters.AddWithValue("@durum", durum);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı.", "Güncelleme Onayı");

            }
            catch
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız!", "Güncelleme Hatası");
            }

            baglanti.Close();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            HastaList.Items.Clear();
            SqlCommand listele = new SqlCommand("Select * from HastaListesi", baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();

            dp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HastaList.Items.Add(dt.Rows[i]["tc"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["AdSoyad"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["DogumTarihi"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Cinsiyet"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Telefon"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Mail"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["Adres"].ToString());
                HastaList.Items[i].SubItems.Add(dt.Rows[i]["TedaviDurumu"].ToString());
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            try
            {
                SqlCommand sil = new SqlCommand("delete from HastaListesi where TC = @tc", baglanti);
                sil.Parameters.AddWithValue("@tc", maskedTCGuncel.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silme İşlemi Başarılı", "Kayıt Silme");


            }
            catch
            {
                MessageBox.Show("Kayıt Silinemedi!", "Silme Hatası");
            }
            baglanti.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e) //tc ile kayıt bulma butonu 
        {

            HastaList.Items.Clear();
            
            try
            {
                baglanti.Open();
                SqlCommand bul = new SqlCommand("select * from HastaListesi where TC like  '%" +textArama.Text +"%'", baglanti);
                bul.Parameters.AddWithValue("@tc", textArama.Text);
                SqlDataReader dr = bul.ExecuteReader();
                while(dr.Read()) 
                { 
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr["TC"].ToString();
                    ekle.SubItems.Add(dr["AdSoyad"].ToString());
                    ekle.SubItems.Add(dr["DogumTarihi"].ToString());
                    ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                    ekle.SubItems.Add(dr["Telefon"].ToString());
                    ekle.SubItems.Add(dr["Mail"].ToString());
                    ekle.SubItems.Add(dr["Adres"].ToString());
                    ekle.SubItems.Add(dr["TedaviDurumu"].ToString());
                    HastaList.Items.Add(ekle);

                }
                baglanti.Close();

            }
            catch
            {
                MessageBox.Show("Aranan Kayıt Bulunamadı!", "Kayıt Bulma Hatası");
            }
            

        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            HastaList.Items.Clear();

            baglanti.Open();
            SqlCommand bul = new SqlCommand("select * from HastaListesi", baglanti);
            bul.Parameters.AddWithValue("@tc", textArama.Text);
            SqlDataReader dr = bul.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["TC"].ToString();
                ekle.SubItems.Add(dr["AdSoyad"].ToString());
                ekle.SubItems.Add(dr["DogumTarihi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["Adres"].ToString());
                ekle.SubItems.Add(dr["TedaviDurumu"].ToString());
                HastaList.Items.Add(ekle);

            }

            baglanti.Close();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            YonetimPaneli yonetimPaneli = new YonetimPaneli();
            yonetimPaneli.Show();
        }
    }
}



