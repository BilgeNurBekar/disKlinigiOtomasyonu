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
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace OrtakProje
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True");
        private void Randevu_Load(object sender, EventArgs e)
        {
           

            SqlCommand komut = new SqlCommand("select * from Randevu", baglan);
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RandHepsi.Items.Add(dt.Rows[i]["RandevuId"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["tc"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["HastaAdSoyad"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["DoktorAdSoyad"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuTarih"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuSaati"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuDurum"].ToString());


            }


            baglan.Open();
            SqlCommand cek = new SqlCommand("select distinct Brans from Doktor", baglan); // brans combobox ına form açıldığında var olan branşları getirir.
            SqlDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                textBrans.Items.Add(oku[0]);
            }

            baglan.Close();


            



        }

        private void textBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();
            textDoktor.Items.Clear(); //branş yüklenirken doktor adını her branşa göre temizlemek için baştan temizler.
            SqlCommand cmd = new SqlCommand("select adsoyad from doktor where brans=@brans", baglan); //bransa göre doktor adlarını doktor combobox ına getirir.
            cmd.Parameters.AddWithValue("@brans", textBrans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textDoktor.Items.Add(dr[0]);
            }
            baglan.Close();

        }

        private void RandHepsi_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (textId.Text != "" && maskedTC.Text != ""
                && textAdSoyad.Text != "" && textDoktor.Text != ""
                    && textBrans.Text != "" && comboSaat.Text != "" && dateTarih.Value != null)
                {
                    baglan.Open();
                    SqlCommand sqlcmd = new SqlCommand("update Randevu set RandevuDurum=1, TC=@tc, HastaAdSoyad=@hadsoyad, DoktorAdSoyad=@dadsoyad, RandevuTarih=@rtarih, RandevuSaati=@rsaat where RandevuId=@id", baglan);

                    sqlcmd.Parameters.AddWithValue("@tc", maskedTC.Text);
                    sqlcmd.Parameters.AddWithValue("@hadsoyad", textAdSoyad.Text);
                    sqlcmd.Parameters.AddWithValue("@dadsoyad", textDoktor.Text);
                    sqlcmd.Parameters.AddWithValue("@rtarih", dateTarih.Value);
                    sqlcmd.Parameters.AddWithValue("@rsaat", comboSaat.Text);
                    sqlcmd.Parameters.AddWithValue("@id", textId.Text);
                    sqlcmd.ExecuteNonQuery();

                    MessageBox.Show("Randevu Başarı İle Alındı!", "Randevu Alım", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglan.Close();
                }
                else
                {
                    MessageBox.Show("Bu alanlar boş bırakılamaz!", "Randevu Alım hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                MessageBox.Show("Randevu Alınamadı Tekrar Deneyiniz!", "Randevu Alım Hatası");
            }
        }

        private void RandHepsi_DoubleClick(object sender, EventArgs e)
        {
            //baglan.Open();
            //SqlCommand sqlcmd = new SqlCommand("select  brans from doktor where AdSoyad=@adsoyad", baglan);
            //sqlcmd.Parameters.AddWithValue("@adsoyad", RandHepsi.SelectedItems[0].SubItems[3].Text);
            //SqlDataReader reader = sqlcmd.ExecuteReader();
            //sqlcmd.ExecuteNonQuery();
            //while (reader.Read())
            //{
            //    textBrans.Items.Add(reader[0]);
            //}
            //fullrowselect true yaparak bilgilerin tıklandığında boxlara gelmesi sağlandı. 
                textId.Text = RandHepsi.SelectedItems[0].SubItems[0].Text;
                maskedTC.Text = RandHepsi.SelectedItems[0].SubItems[1].Text;
                textAdSoyad.Text = RandHepsi.SelectedItems[0].SubItems[2].Text;
                textDoktor.Text = RandHepsi.SelectedItems[0].SubItems[3].Text;
                dateTarih.Text = RandHepsi.SelectedItems[0].SubItems[4].Text;
                comboSaat.Text = RandHepsi.SelectedItems[0].SubItems[5].Text;
            //baglan.Close();
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            try
            {
                SqlCommand sil = new SqlCommand("delete from randevu where RandevuId=@id", baglan);
                sil.Parameters.AddWithValue("@id", textId.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silme İşlemi Başarılı", "Kayıt Silme");


            }
            catch
            {
                MessageBox.Show("Kayıt Silinemedi!", "Silme Hatası");
            }
            baglan.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

            RandHepsi.Items.Clear();

            try
            {
                baglan.Open();
                SqlCommand bul = new SqlCommand("select * from Randevu where DoktorAdSoyad like  '%" + textArama.Text + "%'", baglan);
                //bul.Parameters.AddWithValue("@tc", textArama.Text);
                SqlDataReader dr = bul.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = dr["RandevuId"].ToString();
                    ekle.SubItems.Add(dr["TC"].ToString());
                    ekle.SubItems.Add(dr["HastaAdSoyad"].ToString());
                    ekle.SubItems.Add(dr["DoktorAdSoyad"].ToString());
                    ekle.SubItems.Add(dr["RandevuTarih"].ToString());
                    ekle.SubItems.Add(dr["RandevuSaati"].ToString());
                    ekle.SubItems.Add(dr["RandevuDurum"].ToString());
                    RandHepsi.Items.Add(ekle);

                }
                baglan.Close();

            }
            catch
            {
                MessageBox.Show("Aranan Kayıt Bulunamadı!", "Kayıt Bulma Hatası");
            }

        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            RandHepsi.Items.Clear();
            baglan.Open();
            SqlCommand bul = new SqlCommand("select * from Randevu", baglan);
            bul.Parameters.AddWithValue("@tc", textArama.Text);
            SqlDataReader dr = bul.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["RandevuId"].ToString();
                ekle.SubItems.Add(dr["tc"].ToString());
                ekle.SubItems.Add(dr["HastaAdSoyad"].ToString());
                ekle.SubItems.Add(dr["DoktorAdSoyad"].ToString());
                ekle.SubItems.Add(dr["RandevuTarih"].ToString());
                ekle.SubItems.Add(dr["RandevuSaati"].ToString());
                ekle.SubItems.Add(dr["RandevuDurum"].ToString());
                
                RandHepsi.Items.Add(ekle);

            }

            baglan.Close();
        }

        private void dateTarih_ValueChanged(object sender, EventArgs e)
        {
            
            baglan.Open();
            comboSaat.Items.Clear();
            SqlCommand cek2 = new SqlCommand("select RandevuSaati from Randevu where RandevuDurum=0 and (RandevuTarih=@tarih and DoktorAdSoyad=@doktor)", baglan); // brans combobox ına form açıldığında var olan branşları getirir.

            cek2.Parameters.AddWithValue("@tarih", dateTarih.Value);
            cek2.Parameters.AddWithValue("@doktor", textDoktor.Text);
            SqlDataReader oku2 = cek2.ExecuteReader();

            while (oku2.Read())
            {
                comboSaat.Items.Add(oku2[0]);
            }

            baglan.Close();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            RandHepsi.Items.Clear();
            SqlCommand listele = new SqlCommand("Select * from Randevu", baglan);
            SqlDataAdapter dp = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();

            dp.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RandHepsi.Items.Add(dt.Rows[i]["RandevuId"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["TC"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["HastaAdSoyad"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["DoktorAdSoyad"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuTarih"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuSaati"].ToString());
                RandHepsi.Items[i].SubItems.Add(dt.Rows[i]["RandevuDurum"].ToString());
 
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //panelAlt.Visible = false;

        }

        private void comboBransDktr_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDktrKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDktrRandevu_Click(object sender, EventArgs e)
        {
            DoktorRandevu doktorRandevu = new DoktorRandevu();
            doktorRandevu.Show();
        }
    }
}

