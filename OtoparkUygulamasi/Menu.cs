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
    public partial class Menu : Form
    {
   

        public Menu()
        {
            InitializeComponent();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            AracGirisi ff = new AracGirisi();
            ff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AracCikisiveUcretlendirme ff = new AracCikisiveUcretlendirme();
            ff.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               AboneBilgileri ff = new AboneBilgileri();
               ff.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                AbonelikOlustur ff = new AbonelikOlustur();
                ff.Show();
        }
        

        private void OtoparktakiAracButton_Click(object sender, EventArgs e)
        {
            OtoparktaBulunanAraclar ff = new OtoparktaBulunanAraclar();
            ff.Show();
        }

        private void TarifeTanimlaButton_Click(object sender, EventArgs e)
        {
            TarifeTanimlama ff = new TarifeTanimlama();
            ff.Show();
        }

        private void PlakaGirisCikisButton_Click(object sender, EventArgs e)
        {
            PlakaGirisCikisSorgulama ff = new PlakaGirisCikisSorgulama();
            ff.Show();
        }

        private void AylikKazancButton_Click(object sender, EventArgs e)
        {
            AylikKazanc ff = new AylikKazanc();
            ff.Show();
        }

        private void AktifAracButton_Click(object sender, EventArgs e)
        {
            AktifAraclar ff = new AktifAraclar();
            ff.Show();
        }
    }
}
