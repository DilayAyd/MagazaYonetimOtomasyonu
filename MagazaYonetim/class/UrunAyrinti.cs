using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaYonetim
{
    public class UrunAyrinti
    {
        public string Ayrinti { get; set; }
        public string Ad { get; set; }
        public int UrunKodu { get; set; }
        public decimal Fiyatı { get; set; }
        public int UrunAdet { get; set; }
        public int Kategori { get; set; }
        public decimal Tutar { get; set; }
        private int Indirim { get; set; }
        public int Miktar { get; set; }

        public List<Urun> TemizlikUrunler { get; set; }
        public List<Urun>GidaUrunler { get; set; }
        public List<Urun> KampanyaUrunler { get; set; }
    }
}
