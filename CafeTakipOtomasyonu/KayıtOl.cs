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
using System.Net.Mail;

namespace CafeTakipOtomasyonu
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        SqlConnection baglantiKayit = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");
        MailMessage eposta = new MailMessage();
        Random rnd = new Random();
        int sayi;
        private void kayıtOlKullaniciAdiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            if (kayıtOlSifreText.Text != kayıtOlSifreTekrarlaText.Text || kayıtOlSifreText.Text == ""||kayıtOlMailText.Text=="")
            {
                MessageBox.Show("Şifreler uyuşmuyor veya şifre kısmını boş bıraktınız.Lütfen tekrar deneyiniz.");
            }
            else
            {
                //Anasayfa kullaniciUyeOl = new Anasayfa();
                //kullaniciUyeOl.Show();
                MailGonder();
                //this.Hide();                             
            }

        }
        void MailGonder()
        {
            sayi = rnd.Next(100000, 999999);
            eposta.From = new MailAddress("mustafaabozaslan@hotmail.com");
            eposta.To.Add(kayıtOlMailText.Text);
            eposta.Subject = "Kayıt Ol ";
            eposta.Body = "Doğrulama Kodunuz : " + sayi;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mustafaabozaslan@hotmail.com", "Bzsln27.");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(eposta);
            MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz.");
            


        }

       

        private void kayitOlMailOnaylaButton_Click_1(object sender, EventArgs e)
        {
            if (kayitOlMailOnaylaText.Text == sayi.ToString())
            {
                baglantiKayit.Open();
                SqlCommand yeniKayıt = new SqlCommand("insert into tbl_Kullanicilar(Mail,Şifre) values (@k1,@k2)", baglantiKayit);
                yeniKayıt.Parameters.AddWithValue("@k1", kayıtOlMailText.Text);
                yeniKayıt.Parameters.AddWithValue("@k2", kayıtOlSifreText.Text);
                yeniKayıt.ExecuteNonQuery();
                baglantiKayit.Close();
                MessageBox.Show("Üye Oldunuz.");
                this.Close();
                Anasayfa uye = new Anasayfa();
                uye.Show();
            }
            else
            {
                MessageBox.Show("kod eşleşmiyor.");
            }
        }

        
    }
}
//alperendemir833@gmail.com