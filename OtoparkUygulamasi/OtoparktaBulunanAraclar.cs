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
using System.Data.Sql;

namespace OtoparkUygulamasi
{
    public partial class OtoparktaBulunanAraclar : Form
    {
        public OtoparktaBulunanAraclar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");

        private void OtoparktaBulunanAraclar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracListesi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From GirisCikisKayitlari Where CikisTarihi is Null",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                AracListesi.Items.Add(read[0]+ "      "+ read[1]+"            " + read[2] + "            "+read[3]+"               "+read[4]);
            }
            baglanti.Close();
        }

        private void AracListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
