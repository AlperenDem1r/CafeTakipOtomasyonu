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
using System.Net;
using System.Net.Mail;

namespace CafeTakipOtomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglantiGiris = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            Anasayfa kullaniciGirisi1 = new Anasayfa();
            kullaniciGirisi1.Show();

            baglantiGiris = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");
            cmd = new SqlCommand();
            baglantiGiris.Open();
            cmd.Connection = baglantiGiris;
            cmd.CommandText = "Select *from tbl_Kullanicilar where Mail= '" + girisMailText.Text +
                "'And Şifre='" + girisSifreText.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Mail Adresi veya Şifre");
                
            }
            baglantiGiris.Close();
            
        }

        private void girisSifreniziMiUnutunuz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreUnuttu sifreUnuttum = new SifreUnuttu();
            sifreUnuttum.Show();

        }

        public void girisKullaniciAdiText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
       
}
