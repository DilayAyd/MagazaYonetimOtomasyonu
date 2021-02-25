using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaYonetim
{
    public class Calisanlar

    {

        private string ad;
        public Ad
            { 
            get{return ad ;} 
            set{ad= value ;} 
              }
        public string Soyad { get; set; }
        public long Telefon { get; set; }
        public string Adres { get; set; }
        public int ID { get; set; }
        public string Pozisyon { get; set; }
        public long Maas { get; set; }
        public string Sube { get; set; }
        public int IzinGunu { get; set; }
        public int YillikIzin { get; set; }

        public List<Calisanlar> CalisanKisiler { get; set; }

        public virtual void CalisanBilgisiDoldur(string Ad, string Soyad, string ID)
        {
            this.Ad = Ad.ToUpper();
            this.Soyad = Soyad.ToUpper();
        }

    }
}

