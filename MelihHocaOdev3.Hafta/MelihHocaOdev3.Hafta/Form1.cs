using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelihHocaOdev3.Hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("muhendis");*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdTxt.Text=="")
            {
                MessageBox.Show("İsim Girin");
            }
            else if (AdresTxt.Text == "")
            {
                MessageBox.Show("Adres Girin");
            }
            else if (YasTxt.Text == "")
            {
                MessageBox.Show("Yaş Girin");
            }
            else if (comboBox1.Text == "Unvan Seçin...")
            {
                MessageBox.Show("Ünvan Girin");
            }
            else if (MesaiSaatiTxt.Text == "")
            {
                MessageBox.Show("Mesai Saati Girin");
            }
            else if (comboBox1.Text == "İşçi")
            {
                Personel pers = new Personel(AdTxt.Text, AdresTxt.Text, comboBox1.Text, Convert.ToInt32(YasTxt.Text), Convert.ToInt32(MesaiSaatiTxt.Text));

                MessageBox.Show(pers.ucretHesapla().ToString());    
            }
            else if(comboBox1.Text=="Mühendis")
            {
            Personel pers = new Personel(AdTxt.Text, AdresTxt.Text, comboBox1.Text, Convert.ToInt32(YasTxt.Text), Convert.ToInt32(MesaiSaatiTxt.Text));

                pers.ucretHesapla(1000);
            }
        }
    }
}
