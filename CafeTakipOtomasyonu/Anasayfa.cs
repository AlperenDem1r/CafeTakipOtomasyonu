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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");
        private void girisAnasayfa_Click(object sender, EventArgs e)
        {SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Uygulama_2;Integrated Security=True");
            Giris kullaniciGirisi = new Giris();
            kullaniciGirisi.Show();
            this.Hide();
        }

        private void uyeOlAnasayfa_Click(object sender, EventArgs e)
        {
            KayıtOl kullaniciGirisi = new KayıtOl();
            kullaniciGirisi.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void iceceklerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
