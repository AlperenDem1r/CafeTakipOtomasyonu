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
            k=1;
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
           
        }

        private void MasaSiparis_Load(object sender, EventArgs e)
        {

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

            }
            for (int i = 0; i < urunOzetList.Items.Count; i++)
            if (durum == true&&(urunList.SelectedItems[0].Text == urunOzetList.Items[i].SubItems[0].Text))
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
            Siparisler siparisler = new Siparisler();
            siparisler.Show();

        }
    }
}
