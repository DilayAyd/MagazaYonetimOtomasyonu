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
    public partial class AnaSayfa : Form
    {


        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void ClsnBilgibtn_Click(object sender, EventArgs e)
        {
            CalisanBilgi calisanBilgi = new CalisanBilgi();
                calisanBilgi.Show();
                this.Hide(); 

        }

        private void MrkBilgibtn_Click(object sender, EventArgs e)
        {
            MarketBilgi marketBilgi = new MarketBilgi();
            marketBilgi.Show();
            this.Hide();
        }

        private void StokBilgibtn_Click(object sender, EventArgs e)
        {
            StokBilgisi stokBilgisi = new StokBilgisi();
            stokBilgisi.Show();
            this.Hide();
        }
    }
}
