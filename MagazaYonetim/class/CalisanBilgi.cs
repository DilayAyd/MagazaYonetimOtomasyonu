using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaYonetim
{
    public partial class CalisanBilgi : Form
    {
        public CalisanBilgi()
        {
            InitializeComponent();
        }

        private void CalisanBilgi_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public string GidaUrunListele()
        {
            string mesaj = "";
            foreach (Urun g in GidaUrunlerListesi)
            {
                {
                    mesaj += "\n Ürün Kodu: " + g.Ayrinti.UrunKodu.ToString() +
                             " Ürün Adı: " + g.Ayrinti.Ad +
                             " Ürün Fiyatı: " + g.Ayrinti.Fiyatı.ToString();
                }

            }
            return mesaj;
        }
        private void adresyazdir_Click(object sender, EventArgs e)
        {

             GidaUrunListele();
          // List<Calisanlar> CalisanKisiler = new List<Calisanlar>();

            //  Calisanlar C1 = new Calisanlar();

            // C1.Ad = "Gizem";
            // CalisanKisiler.Add(C1);

            // foreach (Calisanlar calisanlar in CalisanKisiler)
            //  {
            //     lboxAdres.Items.Add(calisanlar);
            // }





        }
    }
}
