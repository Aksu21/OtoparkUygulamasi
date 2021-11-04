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
    public partial class TarifeTanimlama : Form
    {
        public TarifeTanimlama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        
        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TarifeTanimlama_Load(object sender, EventArgs e)
        {
            
            comboBox3.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From Abonelikler";
            oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox3.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Abonelikler where Id Like '" + comboBox3.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                textBox1.Text = read["AboneId"].ToString();
                
        
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spInsertTarife";
        
            komut.Parameters.Add("@IlkSaat", SqlDbType.DateTime).Value = dateTimePicker6.Text;
            komut.Parameters.Add("@SonSaat", SqlDbType.DateTime).Value = dateTimePicker7.Text;
            komut.Parameters.Add("@Ucret", SqlDbType.Money).Value = textBox2.Text;
            komut.Parameters.Add("@Aktif", SqlDbType.NVarChar,(50)).Value = comboBox1.SelectedItem;   
            komut.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = dateTimePicker8.Text;
            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Alındı");
            baglanti.Close();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tarifelerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
