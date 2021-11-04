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
    public partial class AracGirisi : Form
    {
        public AracGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Abonelikler where AboneId Like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
           
            baglanti.Close();
        }

        private void AracGirisi_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From Abonelikler";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "spInsertAracGirisCikis";
            komut.Parameters.Add("@AboneId", SqlDbType.Int).Value = comboBox1.Text;
            komut.Parameters.Add("@AracPlaka", SqlDbType.Char, (10)).Value = textBox1.Text;    
            komut.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = dateTimePicker2.Text;
            komut.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            komut.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value =DBNull.Value ;
            komut.Parameters.Add("@Sure", SqlDbType.Int).Value = DBNull.Value;
            komut.Parameters.Add("@Ucret", SqlDbType.Money).Value = DBNull.Value;
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Alındı");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
