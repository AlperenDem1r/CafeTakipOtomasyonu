using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace CafeTakipOtomasyonu
{
    public partial class SifreUnuttu : Form
    {
        public SifreUnuttu()
        {
            InitializeComponent();
        }
        SqlConnection baglantiSifreUnuttu = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=Kullanicilar;Integrated Security=True");
        MailMessage eposta = new MailMessage();
        Random rnd = new Random();
        int sayi;
        SqlCommand cmd;
        SqlCommand komutGuncelle;
        
        
        
        SqlDataReader dr;
        private void sifreYenilemeOnayButton_Click(object sender, EventArgs e)
        {
            if (sifreYenilemeKodText.Text == sayi.ToString())
            {
                baglantiSifreUnuttu.Open();
                SqlCommand komutGuncelle = new SqlCommand("update Tbl_Kullanicilar set Şifre=@g1 where Mail=@g2", baglantiSifreUnuttu);
                komutGuncelle.Parameters.AddWithValue("@g1", sifreYenilemeYeniSifreText.Text);
                komutGuncelle.Parameters.AddWithValue("@g2", sifreYenilemeMailText.Text);
                komutGuncelle.ExecuteNonQuery();
                baglantiSifreUnuttu.Close();
                MessageBox.Show("Kayit Basariyla Guncellendi!");
                Giris k = new Giris();
                k.Show();
            }
            else
            {
                MessageBox.Show("kod eşleşmiyor.");
            }
        }

        private void sifreYenilemeKodGonderButton_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            baglantiSifreUnuttu.Open();
            cmd.Connection = baglantiSifreUnuttu;
            cmd.CommandText = "Select *from tbl_Kullanicilar where Mail= '" + sifreYenilemeMailText.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MailGonder();
            }
            else
            {
                MessageBox.Show("Mail Adresi Bulunamadı.");
            }
            baglantiSifreUnuttu.Close();
        }

        void MailGonder()
        {
            sayi = rnd.Next(1, 9);
            eposta.From = new MailAddress("mustafaabozaslan@hotmail.com");
            eposta.To.Add(sifreYenilemeMailText.Text);
            eposta.Subject = "Şifre Yenileme ";
            eposta.Body = "Doğrulama Kodunuz : " + sayi;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mustafaabozaslan@hotmail.com", "Bzsln27.");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(eposta);
            MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz.");

        }










        //private void mailGonderButton_Click(object sender, EventArgs e)
        //{
        //    
        //}

        //private void mailKontrolButton_Click(object sender, EventArgs e)
        //{
        //    if (mailOnayiText.Text == sayi.ToString())
        //    {
        //        SifreYenileme mailKontrol = new SifreYenileme();
        //        mailKontrol.Show();
        //        this.Close();


        //    }
        //    else
        //        MessageBox.Show("kod eşleşmiyor.");
        //}
    }
}
