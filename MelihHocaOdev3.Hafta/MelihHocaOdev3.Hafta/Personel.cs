using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelihHocaOdev3.Hafta
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, string gUnvan, int gYas, int gMesaiSaati)
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.yas = gYas;
            this.Mesaisaati = gMesaiSaati;
            this.unvan = gUnvan;
        }
        string Ad;
        public string ad { get => Ad; set => Ad = value; }

        string Adres;
        public string adres { get => Adres; set => Adres = value; }

        string Unvan;
        public string unvan { get => Unvan; set => Unvan = value; }

        int Yas;
        public int yas { get => Yas; set => Yas = value; }

        int MesaiSaati;
        public int Mesaisaati { get => MesaiSaati; set => MesaiSaati = value; }

        public int ucretHesapla()
        {
            return this.MesaiSaati * 100;
        }
        public void ucretHesapla(int ekUcret)
        {
            int odenecek = this.MesaiSaati * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());
        }

    
    }
}
