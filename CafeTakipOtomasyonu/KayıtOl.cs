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
        SqlCommand cmd;
        Random rnd = new Random();
        SqlDataReader dr;
        int sayi;
        private void kayıtOlKullaniciAdiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            baglantiKayit.Open();
            cmd.Connection = baglantiKayit;
            cmd.CommandText = "Select *from tbl_Kullanicilar where Mail= '" + kayıtOlMailText.Text + "'";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Bu Mail Adresi Kullanımda Lütfen Başka Bir Mail Adresi Deneyiniz.");
            }
            else
            {
                if (kayıtOlSifreText.Text != kayıtOlSifreTekrarlaText.Text || kayıtOlSifreText.Text == "" || kayıtOlMailText.Text == "")
                {
                    MessageBox.Show("Şifreler uyuşmuyor veya şifre kısmını boş bıraktınız.Lütfen tekrar deneyiniz.");
                }
                else
                {                                       
                    MailGonder();
                                              
                }
            }
            baglantiKayit.Close();
            
            
           
        }
        void MailGonder()
        {
            sayi = rnd.Next(100000, 999999);
            eposta.From = new MailAddress("Monsterkafe@hotmail.com");
            eposta.To.Add(kayıtOlMailText.Text);
            eposta.Subject = "Kayıt Ol ";
            eposta.Body = "Doğrulama Kodunuz : " + sayi;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("Monsterkafe@hotmail.com", "alperen123");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(eposta);
            MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz.");
            

            //Yemek Id masaıd saat fiyat adet 
        }

       

        private void kayitOlMailOnaylaButton_Click_1(object sender, EventArgs e)
        {
            if (kayitOlMailOnaylaText.Text == sayi.ToString())
            {
                baglantiKayit.Open();
                cmd = new SqlCommand("sp_KullaniciKayit", baglantiKayit);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mail", kayıtOlMailText.Text);
                cmd.Parameters.AddWithValue("@Sifre", kayıtOlSifreText.Text);
                cmd.ExecuteNonQuery();
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