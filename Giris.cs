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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=OrtakProje;Integrated Security=True");
         public static string kullanici = "";
        private void btnGiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Kullanici where Kadi=@Kadi and Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@Kadi", txtKadi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kullanici = txtKadi.Text;
                Form1 anaSayfa = new Form1();
                anaSayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
    }
}
