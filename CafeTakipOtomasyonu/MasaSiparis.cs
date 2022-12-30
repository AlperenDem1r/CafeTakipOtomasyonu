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
       
        private void yemekButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Urunler where KatagoriID=1", baglanti);
            
            dataReader= komut.ExecuteReader();
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
            
            string[] veri=new string[3];
            bool durum = true;
            int toplamTutar = 0;
            for (int i = 0; i < urunOzetList.Items.Count; i++)
            {
                if (urunList.SelectedItems[0].Text == urunOzetList.Items[i].SubItems[0].Text)
                {
                    MessageBox.Show("Test");
                    urunOzetList.Items[i].SubItems[1].Text = (Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text) + 1).ToString();
                    urunOzetList.Items[i].SubItems[2].Text = (Convert.ToInt32(urunList.SelectedItems[0].SubItems[1].Text) *Convert.ToInt32(urunOzetList.Items[i].SubItems[1].Text)).ToString();

                    durum = false;
                }


            }

            if (durum==true)
            {
                ListViewItem urun;
                veri[0] = urunList.SelectedItems[0].Text;
                veri[1] = "1";
                veri[2] = urunList.SelectedItems[0].SubItems[1].Text;
                urun =new ListViewItem(veri);
                urunOzetList.Items.Add(urun);

            }

            for (int i = 0; i < urunOzetList.Items.Count; i++)
            {
                toplamTutar += Convert.ToInt32(urunOzetList.Items[i].SubItems[2].Text);

            }
            toplamTutarText.Text = toplamTutar.ToString();
            
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Urunler where KatagoriID=2", baglanti);

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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Urunler where KatagoriID=3", baglanti);

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
    }
}
