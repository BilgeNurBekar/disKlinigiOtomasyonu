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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True");
        public  int toplam =0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            

            try
            {


                if (maskedTC.Text != "" && dateKasa.Value != null)
                {
                    bagla.Open();
                    SqlCommand komutt = new SqlCommand("select tutar from Tutar where TC=@tc and Tarih=@tarih ", bagla);
                    komutt.Parameters.AddWithValue("@tc", maskedTC.Text);
                    
                    komutt.Parameters.AddWithValue("@tarih", DateTime.Parse(dateKasa.Text));

                    SqlDataReader rdd = komutt.ExecuteReader();
                    
                    while (rdd.Read()) 
                    {
                        textTutar.Text = rdd["Tutar"].ToString();

                    }
                    bagla.Close();

                }
                else
                {

                    MessageBox.Show("Lütfen TC kimlik no ve Randevu tarihini giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch
            {
                MessageBox.Show("Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnTahsil_Click(object sender, EventArgs e)
        {
                    
            try
            {



                bagla.Open();
                SqlCommand komutt = new SqlCommand("insert into Kasa (TC,Tarih,Tutar) values ( @tc,@tarih,@tl) ", bagla);
                komutt.Parameters.AddWithValue("@tc", maskedTC.Text);
                komutt.Parameters.AddWithValue("@tl", textTutar.Text);

                komutt.Parameters.AddWithValue("@tarih", DateTime.Parse(dateKasa.Text));
                komutt.ExecuteNonQuery();
                bagla.Close() ;

                MessageBox.Show("Ücret Tahsil Edildi \n Fişinizi Unutmayınız!", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            catch
            {
                MessageBox.Show("Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
