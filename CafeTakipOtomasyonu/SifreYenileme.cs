using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeTakipOtomasyonu
{
    public partial class SifreYenileme : Form
    {
        public SifreYenileme()
        {
            InitializeComponent();
        }
        SqlConnection baglantiSifreYenileme = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");

        private void sifreYenilemeOnayButton_Click(object sender, EventArgs e)
        {
            if (sifreYenilemeText.Text != sifreYenilemeTekrarlaText.Text || sifreYenilemeText.Text=="")
            {
                MessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz.");
            }
            else
            {
              //  baglantiSifreYenileme.Open();
              // SqlCommand sifreYenile = new SqlCommand("Update tbl_Kullanicilar Set Şifre=@sifre Where KullaniciAdi='" + .Text + "'", baglantiSifreYenileme);
              //  sifreYenile.Parameters.AddWithValue("@sifre", sifreYenilemeText.Text);
              //  sifreYenile.ExecuteNonQuery();
              //  baglantiSifreYenileme.Close();
                MessageBox.Show("Şifreniz değiştirildi.");
            }
        }
    }
}
