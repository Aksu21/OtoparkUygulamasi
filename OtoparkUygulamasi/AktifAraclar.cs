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
    public partial class AktifAraclar : Form
    {
        public AktifAraclar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            AktifAracList.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT T.Id, A.AboneId, AB.Ad, AB.Soyad, T.Aktif FROM Tarifeler AS T INNER JOIN Abonelikler AS A ON T.Id = A.Id INNER JOIN AboneBilgileri AS AB ON A.AboneId = AB.AboneId WHERE Aktif = 'Aktif' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                AktifAracList.Items.Add(read[0] + "      " + read[1] + "            " + read[2]);
            }
            baglanti.Close();
        }

        private void AktifAraclar_Load(object sender, EventArgs e)
        {

        }
    }
}
