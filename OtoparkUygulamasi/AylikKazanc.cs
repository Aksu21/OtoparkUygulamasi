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
    public partial class AylikKazanc : Form
    {
        public AylikKazanc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AylikKazanc_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AylikKazancList.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select SUM(Ucret) From Tarifeler Where Month(KayitTarihi)=@Tarih", baglanti);
            komut.Parameters.AddWithValue("@Tarih", comboBox1.Text);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                AylikKazancList.Items.Add(read[0]);
            }
            baglanti.Close();
        }
    }
}
