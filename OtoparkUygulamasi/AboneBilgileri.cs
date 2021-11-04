using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace OtoparkUygulamasi
{
    public partial class AboneBilgileri : Form
    {
     
        public AboneBilgileri()
        {
            InitializeComponent();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertUser"; 
            cmd.Parameters.Add("@AboneId", SqlDbType.Int).Value = comboBox1.Text; 
            cmd.Parameters.Add("@Ad", SqlDbType.VarChar,(20)).Value = textBox1.Text; 
            cmd.Parameters.Add("@Soyad", SqlDbType.VarChar,(20)).Value = textBox2.Text;
            cmd.Parameters.Add("@Adres", SqlDbType.Text).Value = textBox3.Text;
            cmd.Parameters.Add("@Ilce", SqlDbType.VarChar,(20)).Value = textBox5.Text;
            cmd.Parameters.Add("@Il", SqlDbType.VarChar, (20)).Value = textBox4.Text;
            cmd.Parameters.Add("@Telefon", SqlDbType.Char,(11)).Value = textBox6.Text;
            cmd.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Alındı");
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AboneBilgileri_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Abonelikler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["AboneId"]);
            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
