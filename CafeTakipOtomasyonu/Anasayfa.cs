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
using System.Security.Cryptography.X509Certificates;

namespace CafeTakipOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Uygulama_2;Integrated Security=True");

        public static int masaId = 1;

        private void girisAnasayfa_Click(object sender, EventArgs e)
        {
            Giris kullaniciGirisi = new Giris();
            kullaniciGirisi.Show();
            
        }

        private void uyeOlAnasayfa_Click(object sender, EventArgs e)
        {
            KayıtOl kullaniciGirisi = new KayıtOl();
            kullaniciGirisi.Show();
            
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void iceceklerButton_Click(object sender, EventArgs e)
        {

        }

        private void masa1Button_Click(object sender, EventArgs e)
        {
            masaId = 1;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();
            

        }

        private void masa2Button_Click(object sender, EventArgs e)
        {
            masaId = 2;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa3Button_Click(object sender, EventArgs e)
        {
            masaId = 3;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa4Button_Click(object sender, EventArgs e)
        {
            masaId = 4;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa5Button_Click(object sender, EventArgs e)
        {
            masaId = 5;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa6Button_Click(object sender, EventArgs e)
        {
            masaId = 6;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa7Button_Click(object sender, EventArgs e)
        {
            masaId = 7;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa8Button_Click(object sender, EventArgs e)
        {
            masaId = 8;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa9Button_Click(object sender, EventArgs e)
        {
            masaId = 9;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }
        private void masa10Button_Click_1(object sender, EventArgs e)
        {
            masaId = 10;
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();
        }

        private void siparislerButton_Click(object sender, EventArgs e)
        {
            Siparisler siparis = new Siparisler();
            siparis.Show();
        }

       
    }
}
