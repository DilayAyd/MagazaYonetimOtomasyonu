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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kullaniciAd_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (KulAd.Text == "admin" && BoxSifre.Text == "1234")
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }

        }
    }
}
