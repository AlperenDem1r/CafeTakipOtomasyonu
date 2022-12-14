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
using System.Data.Sql;
using System.Data.SqlClient;

namespace CafeTakipOtomasyonu
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        SqlConnection baglantiKayit = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");

        private void kayıtOlKullaniciAdiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            if (kayıtOlSifreText.Text != kayıtOlSifreTekrarlaText.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz.");
            }
            else
            {
                Anasayfa kullaniciUyeOl = new Anasayfa();
                kullaniciUyeOl.Show();
                this.Hide();
                baglantiKayit.Open();
                SqlCommand yeniKayıt = new SqlCommand("insert into tbl_Kullanicilar(Kullanıcı,Şifre) values (@k1,@k2)", baglantiKayit);
                yeniKayıt.Parameters.AddWithValue("@k1", kayıtOlKullaniciAdiText.Text);
                yeniKayıt.Parameters.AddWithValue("@k2", kayıtOlSifreText.Text);
                yeniKayıt.ExecuteNonQuery();
                baglantiKayit.Close();
                MessageBox.Show("Üye Oldunuz.");
            }
        }
    }
}
