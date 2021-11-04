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

namespace OtoparkUygulamasi
{
    public partial class PlakaGirisCikisSorgulama : Form
    {
        public PlakaGirisCikisSorgulama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlakaGirisCikisSorgulama_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM GirisCikisKayitlari";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["AracPlaka"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisCikisSorguList.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AboneId, AracPlaka, GirisTarihi,CikisTarihi From GirisCikisKayitlari Where AracPlaka =@Plaka", baglanti);
            komut.Parameters.AddWithValue("@Plaka", comboBox1.Text);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                GirisCikisSorguList.Items.Add(read[0] + "      " + read[1] + "            " + read[2] + "            " + read[3]);
            }
            baglanti.Close();
        }
    }
}
