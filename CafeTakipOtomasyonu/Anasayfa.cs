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
using System.Data.Common;

namespace CafeTakipOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        SqlDataReader dataReader;
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
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from tbl_MasaDurumu where Durum = 'False' ";
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                string btnRengi = dataReader[0].ToString();                                           
                if (btnRengi== 1.ToString() )
                {
                    masa1Button.BackColor = Color.Firebrick;                  
                }
                if (btnRengi== 2.ToString() )
                {
                    masa2Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 3.ToString() )
                {
                    masa3Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 4.ToString() )
                {
                    masa4Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 5.ToString() )
                {
                    masa5Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 6.ToString() )
                {
                    masa6Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 7.ToString() )
                {
                    masa7Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 8.ToString() )
                {
                    masa8Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 9.ToString() )
                {
                    masa9Button.BackColor = Color.Firebrick;
                }
                if (btnRengi== 10.ToString() )
                {
                    masa10Button.BackColor = Color.Firebrick;
                }
                
            }

            baglanti.Close();
        }
      
        private void masa1Button_Click(object sender, EventArgs e)
        {
            masaId = 1;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();
            

        }

        private void masa2Button_Click(object sender, EventArgs e)
        {
            masaId = 2;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa3Button_Click(object sender, EventArgs e)
        {
            masaId = 3;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa4Button_Click(object sender, EventArgs e)
        {
            masaId = 4;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa5Button_Click(object sender, EventArgs e)
        {
            masaId = 5;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa6Button_Click(object sender, EventArgs e)
        {
            masaId = 6;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa7Button_Click(object sender, EventArgs e)
        {
            masaId = 7;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa8Button_Click(object sender, EventArgs e)
        {
            masaId = 8;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }

        private void masa9Button_Click(object sender, EventArgs e)
        {
            masaId = 9;
            this.Hide();
            MasaSiparis MasaSiparisi = new MasaSiparis();
            MasaSiparisi.ShowDialog();

        }
        private void masa10Button_Click_1(object sender, EventArgs e)
        {
            masaId = 10;
            this.Hide();
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
