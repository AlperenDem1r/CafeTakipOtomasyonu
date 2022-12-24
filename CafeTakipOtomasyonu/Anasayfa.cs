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


namespace CafeTakipOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        
        private void girisAnasayfa_Click(object sender, EventArgs e)
        {SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Uygulama_2;Integrated Security=True");
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
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa2Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa3Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa4Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa5Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa6Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa7Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa8Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa9Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }

        private void masa10Button_Click(object sender, EventArgs e)
        {
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.Show();

        }
    }
}
