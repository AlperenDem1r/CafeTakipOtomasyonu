using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeTakipOtomasyonu
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=cafeOtomasyonu;Integrated Security=True");
        SqlDataReader dataReader;
    
        
        private void urunSiparisList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void siparisleriListeleButton_Click(object sender, EventArgs e)
        {
            bool m = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("sp_ButunSiparisleriGetir", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@HesapDurum", SqlDbType.Bit).Value = m.ToString();
            dataReader = komut.ExecuteReader();
            urunSiparisList.Items.Clear();
            while (dataReader.Read())
            {

                string[] veri = new string[6];
                ListViewItem urun;
                veri[0] = dataReader[0].ToString();
                veri[1] = dataReader[1].ToString();
                veri[2] = dataReader[3].ToString();
                veri[3] = dataReader[4].ToString();
                veri[4] = dataReader[2].ToString();
                veri[5] = dataReader[5].ToString();
                urun = new ListViewItem(veri);
                urunSiparisList.Items.Add(urun);

            }
            baglanti.Close();
        }
    }
}
