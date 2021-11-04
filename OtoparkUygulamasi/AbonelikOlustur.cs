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
    public partial class AbonelikOlustur : Form
    {

        public AbonelikOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-32KBP19;Initial Catalog=Otopark;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AbonelikOlustur_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        bool durum; 
        void tekrar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Abonelikler where AboneId=@AboneNo", baglanti);
            komut.Parameters.AddWithValue("@AboneNo", textBox4.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tekrar();
            if (durum == true)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "spInsertAbonelikler";
                komut.Parameters.Add("@AboneId", SqlDbType.Int).Value = textBox4.Text;
                komut.Parameters.Add("@BaslangicTarihi", SqlDbType.DateTime).Value = dateTimePicker2.Text;
                komut.Parameters.Add("@BitisTarihi", SqlDbType.DateTime).Value = dateTimePicker3.Text;
                komut.Parameters.Add("@AboneUcreti", SqlDbType.Money).Value = textBox3.Text;
                komut.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Alındı");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Başka Bir Abone Numarası Seçiniz!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
