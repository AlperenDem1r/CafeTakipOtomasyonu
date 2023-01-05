using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace CafeTakipOtomasyonu
{
    public partial class MasaSiparis : Form
    {
        public MasaSiparis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        SqlDataReader dataReader;
        SqlCommand komut;

        int k;
        private void yemekButton_Click(object sender, EventArgs e)
        {
            k = 1;
            baglanti.Open();
            komut = new SqlCommand("sp_Katagori", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@KatagoriID", SqlDbType.VarChar, 50).Value = k.ToString();
            dataReader = komut.ExecuteReader();
            urunList.Items.Clear();
            while (dataReader.Read())
            {

                string[] veri = new string[2];
                ListViewItem urun;
                veri[0] = dataReader[2].ToString();
                veri[1] = dataReader[3].ToString();
                urun = new ListViewItem(veri);
                urunList.Items.Add(urun);
            }
            baglanti.Close();

        }

        private void arttırmaButton_Click(object sender, EventArgs e)
        {
            if (urunList.SelectedItems[0].Text == "")
            {
                MessageBox.Show("Lütfen Önce Ürün Seçiniz.");
            }
            else
            {


                string[] veri = new string[3];
                bool durum = true;
                int toplamTutar = 0;
                for (int i = 0; i < urunOzetList.Items.Count; i++)
                {
                    if (urunList.SelectedItems[0].Text == urunOzetList.Items[i].SubItems[0].Text)
                    {
                        urunOzetList.Items[i].SubItems[1].Text = (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text) + 1).ToString();
                        urunOzetList.Items[i].SubItems[2].Text = (Convert.ToInt32(urunList.SelectedItems[0].SubItems[1].Text) * Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text)).ToString();

                        durum = false;
                    }


                }

                if (durum == true)
                {
                    ListViewItem urun;
                    veri[0] = urunList.SelectedItems[0].Text;
                    veri[1] = "1";
                    veri[2] = urunList.SelectedItems[0].SubItems[1].Text;
                    urun = new ListViewItem(veri);
                    urunOzetList.Items.Add(urun);

                }

                for (int i = 0; i < urunOzetList.Items.Count; i++)
                {
                    toplamTutar += Convert.ToInt32(urunOzetList.Items[i].SubItems[2].Text);

                }
                toplamTutarText.Text = toplamTutar.ToString();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (urunOzetList.Items.Count!=adet.Count)
            {

                if (urunOzetList.Items.Count> adet.Count)
                {
                    for (int i = 0; i < urunOzetList.Items.Count; i++)
                    {
                        if (urunAdi.Count<=i)
                        {
                            SqlCommand komut = new SqlCommand();
                            baglanti.Open();
                            komut.Connection = baglanti;
                            komut.CommandText = "insert into tbl_Siparisler(MasaID,Urunler,Adet,Tutar,Tarih,Saat,HesapDurum) values(@masaid,@urunler,@adet,@tutar,@tarih,@saat,@hesapdurum)";
                            komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
                            komut.Parameters.AddWithValue("@urunler", urunOzetList.Items[i].SubItems[0].Text);
                            komut.Parameters.AddWithValue("@adet", urunOzetList.Items[i].SubItems[1].Text);
                            komut.Parameters.AddWithValue("@tutar", urunOzetList.Items[i].SubItems[2].Text);
                            komut.Parameters.AddWithValue("@tarih", DateTime.Now.Date);
                            komut.Parameters.AddWithValue("@saat", DateTime.Now.ToString("HH:mm"));
                            komut.Parameters.AddWithValue("@hesapdurum", false);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }
                }
                /*else
                {
                    for (int i = 0; i < adet.Count; i++)
                    {
                        for (int j = 0; j < urunOzetList.Items.Count; j++)
                        {
                            if (urunOzetList.Items[j].SubItems[0].Text == urunAdi[i].ToString())
                            {
                                urunOzetList.Items[j].SubItems[0].Text = "";
                            }
                        }
                    }
                    for (int i = 0; i < urunOzetList.Items.Count+1; i++)
                    {
                        if (urunOzetList.Items[i].SubItems[0].Text!="")
                        {

                            SqlCommand komut = new SqlCommand();
                            baglanti.Open();
                            komut.Connection = baglanti;
                            komut.CommandText = "delete from tbl_Siparişler where MasaID=@masaid and Urunler=@urunler and HesapDurum='False'";
                            komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
                            komut.Parameters.AddWithValue("@urunler", urunOzetList.Items[i].SubItems[0].Text);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }
                    
                }*/
              
            }
            else
            {
                for (int i = 0; i < adet.Count; i++)
                {
                    if (urunOzetList.Items[i].SubItems[1].Text != adet[i].ToString())
                    {
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "update tbl_Siparisler set Adet=@adet,Tutar=@tutar where Urunler=@urunler and MasaID=@masaid and HesapDurum='False'";
                        komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
                        komut.Parameters.AddWithValue("@adet", urunOzetList.Items[i].SubItems[1].Text);
                        komut.Parameters.AddWithValue("@urunler", urunOzetList.Items[i].SubItems[0].Text);
                        komut.Parameters.AddWithValue("@tutar", urunOzetList.Items[i].SubItems[2].Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
            }
           /* SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into tbl_Siparisler(MasaID,Urunler,Tutar,Tarih,Saat,HesapDurum) values(@masaid,@urunler,@tutar,@tarih,@saat,@hesapdurum)";
            komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
            komut.Parameters.AddWithValue("@urunler", urunOzetList.Items[j].SubItems[1].Text + "-" + urunOzetList.Items[j].SubItems[0].Text);
            komut.Parameters.AddWithValue("@tutar", urunOzetList.Items[j].SubItems[2].Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.Date);
            komut.Parameters.AddWithValue("@saat", DateTime.Now.ToString("HH:mm"));
            komut.Parameters.AddWithValue("@hesapdurum", false);
            komut.ExecuteNonQuery();
            baglanti.Close();*/
        }

        ArrayList adet = new ArrayList();
        ArrayList urunAdi = new ArrayList();
        private void MasaSiparis_Load(object sender, EventArgs e)
        {

           
            urunOzetList.Items.Clear();
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select Urunler,Adet,Tutar from tbl_Siparisler where HesapDurum='False' and masaID=@masaid";
            komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                
                string[] veri = new string[3];
                ListViewItem urun;
                veri[0] = dataReader[0].ToString();
                urunAdi.Add(dataReader[0].ToString());
                veri[1] = dataReader[1].ToString();
                adet.Add(dataReader[1].ToString());
                veri[2] = dataReader[2].ToString();
                urun = new ListViewItem(veri);
                urunOzetList.Items.Add(urun);
            }
            baglanti.Close();

        }

        private void masayıAcButton_Click(object sender, EventArgs e)
        {
        }

        private void tatlıButton_Click(object sender, EventArgs e)
        {
            k = 2;
            baglanti.Open();
            komut = new SqlCommand("sp_Katagori", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@KatagoriID", SqlDbType.VarChar, 50).Value = k.ToString();
            dataReader = komut.ExecuteReader();
            urunList.Items.Clear();
            while (dataReader.Read())
            {

                string[] veri = new string[2];
                ListViewItem urun;
                veri[0] = dataReader[2].ToString();
                veri[1] = dataReader[3].ToString();
                urun = new ListViewItem(veri);
                urunList.Items.Add(urun);

            }
            baglanti.Close();

        }

        private void icecekButton_Click(object sender, EventArgs e)
        {
            k = 3;
            baglanti.Open();
            komut = new SqlCommand("sp_Katagori", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@KatagoriID", SqlDbType.VarChar, 50).Value = k.ToString();

            dataReader = komut.ExecuteReader();
            urunList.Items.Clear();
            while (dataReader.Read())
            {

                string[] veri = new string[2];
                ListViewItem urun;
                veri[0] = dataReader[2].ToString();
                veri[1] = dataReader[3].ToString();
                urun = new ListViewItem(veri);
                urunList.Items.Add(urun);
            }
            baglanti.Close();
        }

        private void azaltmaButton_Click(object sender, EventArgs e)
        {
            
            string[] veri = new string[3];
            bool durum = true;
            int toplamTutar = 0;
            for (int i = 0; i < urunOzetList.Items.Count; i++)
            {
                if (urunList.SelectedItems[0].Text == urunOzetList.Items[i].SubItems[0].Text)
                {
                    if (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text)>1)
                    {
                        if (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text) <= 1)
                        {
                            urunOzetList.Items[i].Remove();

                        }
                        else
                        {

                            urunOzetList.Items[i].SubItems[2].Text = (Convert.ToInt32(urunOzetList.Items[i].SubItems[2].Text) -
                                Convert.ToInt32(urunList.SelectedItems[0].SubItems[1].Text)).ToString();

                            urunOzetList.Items[i].SubItems[1].Text = (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text) - 1).ToString();

                        }
                        durum = false;
                    }
                    else
                    {
                        SqlCommand komut = new SqlCommand();
                        baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "delete from tbl_Siparisler where MasaID=@masaid and Urunler=@urunler and HesapDurum='False'";
                        komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
                        komut.Parameters.AddWithValue("@urunler", urunOzetList.Items[i].SubItems[0].Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        urunOzetList.Items[i].Remove();
                    }

                }

            }
            for (int i = 0; i < urunOzetList.Items.Count; i++)
                if (durum == true && (urunList.SelectedItems[0].Text == urunOzetList.Items[i].SubItems[0].Text))
                {
                    if (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text) >= 1)
                    {
                        ListViewItem urun;
                        veri[0] = urunList.SelectedItems[0].Text;
                        veri[1] = "0";
                        veri[2] = urunList.SelectedItems[0].SubItems[1].Text;
                        urun = new ListViewItem(veri);
                        urunOzetList.Items.Add(urun);
                    }
                }
            for (int i = 0; i < urunOzetList.Items.Count; i++)
            {
                toplamTutar += Convert.ToInt32(urunOzetList.Items[i].SubItems[2].Text);

            }
            toplamTutarText.Text = toplamTutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update tbl_Siparisler set HesapDurum='True' where MasaID=@masaid";
            komut.Parameters.AddWithValue("@masaid", Anasayfa.masaId);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
            //Siparisler siparisler = new Siparisler();
           //siparisler.Show();

        }

        private void MasaSiparis_FormClosing(object sender, FormClosingEventArgs e)
        {


            MessageBox.Show("Hesabı Kaydettiğinizden emin olun.");


        }
    }
}
