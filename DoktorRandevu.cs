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
using static System.Net.Mime.MediaTypeNames;

namespace OrtakProje
{
    public partial class DoktorRandevu : Form
    {
        public DoktorRandevu()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True");
        private void comboBransDktr_SelectedIndexChanged(object sender, EventArgs e)
        {
            bagla.Open();
            comboDoktorDktr.Items.Clear(); //branş yüklenirken doktor adını her branşa göre temizlemek için baştan temizler.
            SqlCommand cmd = new SqlCommand("select adsoyad from doktor where brans=@bbrans", bagla); //bransa göre doktor adlarını doktor combobox ına getirir.
            cmd.Parameters.AddWithValue("@bbrans", comboBransDktr.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboDoktorDktr.Items.Add(dr[0]);
            }
            bagla.Close();

        }

        private void DoktorRandevu_Load(object sender, EventArgs e)
        {
            comboBransDktr.Items.Clear();
            bagla.Open();
            SqlCommand cek2 = new SqlCommand("select  distinct Brans from Doktor", bagla); // brans combobox ına form açıldığında var olan branşları getirir.
            SqlDataReader oku2 = cek2.ExecuteReader();
            while (oku2.Read())
            {
                comboBransDktr.Items.Add(oku2[0]);
            }

            bagla.Close();
        }

        private void btnDktrKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboDoktorDktr.Text!="" && dateDktr.Value!=null && comboDktrSaat.Text!="") 
                {
                    bagla.Open();
                    SqlCommand sqlcmd = new SqlCommand("insert into randevu (DoktorAdSoyad,RandevuTarih,RandevuSaati) values (@drad,@randt,@rands)", bagla);

                    sqlcmd.Parameters.AddWithValue("@drad", comboDoktorDktr.Text);
                    sqlcmd.Parameters.AddWithValue("@randt", dateDktr.Value);
                    sqlcmd.Parameters.AddWithValue("@rands", comboDktrSaat.Text);

                    sqlcmd.ExecuteNonQuery();

                    MessageBox.Show("Randevu Başarı İle Alındı!", "Randevu Alım", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    bagla.Close();
                }
                else
                {
                    MessageBox.Show("Bu alanlar boş bırakılamaz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }


            }
            catch
            {
                MessageBox.Show("Randevu Alınamadı Tekrar Deneyiniz!", "Randevu Alım Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
