﻿using System;
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
        MailMessage eposta = new MailMessage();
        Random rnd = new Random();
        int sayi;


        void MailGonder()
        {
            sayi = rnd.Next(100000, 9999999);
            eposta.From = new MailAddress("mustafaabozaslan@hotmail.com");
            eposta.To.Add(mailGonderText.Text);
            eposta.Subject = "Şifre Yenileme ";
            eposta.Body = "Doğrulama Kodunuz : "+sayi;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mustafaabozaslan@hotmail.com", "Bzsln27.");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(eposta);
            MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz.");

        }

        private void mailGonderButton_Click(object sender, EventArgs e)
        {
            MailGonder();
        }

        private void mailKontrolButton_Click(object sender, EventArgs e)
        {
            if (mailOnayiText.Text == sayi.ToString())
            {
                SifreYenileme mailKontrol = new SifreYenileme();
                mailKontrol.Show();
                this.Close();


            }
            else
                MessageBox.Show("kod eşleşmiyor.");
        }
    }
}
