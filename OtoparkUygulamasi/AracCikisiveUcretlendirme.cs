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
    public partial class AracCikisiveUcretlendirme : Form
    {
        public AracCikisiveUcretlendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AracCikisiveUcretlendirme_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlDataReader oku;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From GirisCikisKayitlari";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[2].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From GirisCikisKayitlari where AracPlaka Like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())                                       // Araç Plakayı veritabanından Combobox'a çektikten sonrası için. 
            {                                                         // Yani butona tıklandığında giris tarihini ve aboneıd yi textboxa veriyoruz.      
                textBox1.Text = read["GirisTarihi"].ToString();
                textBox3.Text = read["AboneId"].ToString();
            }
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan fark;
            fark = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(textBox1.Text);
            textBox2.Text = fark.TotalMinutes.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateGirisCikis";
            cmd.Parameters.Add("@AboneId", SqlDbType.Int).Value = textBox3.Text;
            cmd.Parameters.Add("@AracPlaka", SqlDbType.VarChar, (10)).Value = DBNull.Value;
            cmd.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = dateTimePicker2.Text;
            cmd.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = textBox1.Text;
            cmd.Parameters.Add("@Sure", SqlDbType.Float).Value = textBox2.Text;
            cmd.Parameters.Add("@Ucret", SqlDbType.Money).Value = textBox4.Text;
            cmd.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = dateTimePicker1.Text;
        
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Kayıt Alındı");
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
