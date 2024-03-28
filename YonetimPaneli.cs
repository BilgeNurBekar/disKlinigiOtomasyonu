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
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True"); //veritabanı baglantisini yapar

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAdSoyad.Text != "" && txtSifre.Text != "" && txtKadi.Text != "")
                {

                    baglanti.Open();

                    SqlCommand tekrar = new SqlCommand("select count(*) from Kullanici where Kadi=@Kadi", baglanti);
                    tekrar.Parameters.AddWithValue("@Kadi", txtKadi.Text);
                    int sonuc = (int)tekrar.ExecuteScalar();
                    if (sonuc == 0)
                    {
                        SqlCommand komut = new SqlCommand("Insert into Kullanici (Ad_Soyad,Kadi,Sifre,Yonetici) Values (@Ad_Soyad,@Kadi,@Sifre,@Yonetici)", baglanti);
                        komut.Parameters.AddWithValue("@Ad_Soyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@Kadi", txtKadi.Text);
                        komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                        komut.Parameters.AddWithValue("@Yonetici", false);


                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("kullanici kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("kullanıcı adı alınmış ");
                    }
                }
                else
                {
                    MessageBox.Show("Boş alanları doldurun.");
                }
            }
            catch
            {
                MessageBox.Show("Kullanıcı Kaydedilemedi. Bilgileri kontrol edip tekrar deneyin.");
                baglanti.Close();
            }
        }

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {
            if (txtDoktor.Text != "")
            {
                baglanti.Open();

                SqlCommand tekrar = new SqlCommand("select count(*) from Doktor where AdSoyad=@AdSoyad", baglanti);
                tekrar.Parameters.AddWithValue("@AdSoyad", txtDoktor.Text);
                int sonuc = (int)tekrar.ExecuteScalar();
                if (sonuc == 0)
                {
                    SqlCommand komut = new SqlCommand("Insert into Doktor (AdSoyad,Brans) Values (@AdSoyad,@Brans)", baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", txtDoktor.Text);
                    komut.Parameters.AddWithValue("@Brans", comboBrans.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("doktor kaydedildi.");
                }
                else
                    MessageBox.Show("doktor zaten  kaydedilmiş ");
            }
            else
                MessageBox.Show("Boş alanları doldurun.");
        }

        private void btnKaydetY_Click(object sender, EventArgs e)
        {
            if (txtAdSoyadY.Text != "" && txtSifreY.Text != "" && txtKadiY.Text != "")
            {
                baglanti.Open();

                SqlCommand tekrar = new SqlCommand("select count(*) from Kullanici where Kadi=@Kadi", baglanti);
                tekrar.Parameters.AddWithValue("@Kadi", txtKadiY.Text);
                int sonuc = (int)tekrar.ExecuteScalar();
                if (sonuc == 0)
                {
                    SqlCommand komut = new SqlCommand("Insert into Kullanici (Ad_Soyad,Kadi,Sifre,Yonetici) Values (@Ad_Soyad,@Kadi,@Sifre,@Yonetici)", baglanti);
                    komut.Parameters.AddWithValue("@Ad_Soyad", txtAdSoyadY.Text);
                    komut.Parameters.AddWithValue("@Kadi", txtKadiY.Text);
                    komut.Parameters.AddWithValue("@Sifre", txtSifreY.Text);
                    komut.Parameters.AddWithValue("@Yonetici", true);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("kullanici kaydedildi.");
                }
                else
                    MessageBox.Show("kullanıcı adı alınmış ");
            }
            else
                MessageBox.Show("Boş alanları doldurun.");
        }

        private void txtDoktor_TextChanged(object sender, EventArgs e)
        {

            comboBrans.Items.Clear();
            baglanti.Open();
            SqlCommand cek = new SqlCommand("select distinct Brans from Doktor", baglanti); // brans combobox ına form açıldığında var olan branşları getirir.
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                comboBrans.Items.Add(oku[0]);
            }

            baglanti.Close();


        }
    }
}
