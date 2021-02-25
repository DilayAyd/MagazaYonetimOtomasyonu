using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaYonetim
{
    public class Magaza
    {
        public List<Urun> GidaUrunlerListesi { get; set; }
        public List<Urun> TemizlikUrunlerListesi { get; set; }
        public List<Urun> IndirimUrunlerListesi { get; set; }

        public void GidaUrunEkle(Urun g)
        {



            bool x = true;
            foreach (Urun ur in GidaUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == g.Ayrinti.UrunKodu)
                {
                    x = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + g.Ayrinti.UrunAdet;
                }

            }


            if (x == true)
            {
                GidaUrunlerListesi.Add(g);
                x = true;

            }


        }

        public void TemizlikUrunEkle(Urun t)
        {



            bool y = true;
            foreach (Urun ur in TemizlikUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == t.Ayrinti.UrunKodu)
                {
                    y = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + t.Ayrinti.UrunAdet;
                }

            }


            if (y == true)
            {
               TemizlikUrunlerListesi.Add(t);
                y = true;

            }


        }


        public void IndirimUrunEkle(Urun i)
        {



            bool z = true;
            foreach (Urun ur in IndirimUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == i.Ayrinti.UrunKodu)
                {
                    z = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + i.Ayrinti.UrunAdet;
                }

            }


            if (z == true)
            {
                IndirimUrunlerListesi.Add(i);
                z = true;

            }

        }

        public void GidaUrunCikar(Urun g)
        {



            bool x = true;
            foreach (Urun ur in GidaUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == g.Ayrinti.UrunKodu)
                {
                    x = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + g.Ayrinti.UrunAdet;
                }

            }


            if (x == true)
            {
                GidaUrunlerListesi.Remove(g);
                x = true;

            }


        }

        public void TemizlikUrunCikar(Urun t)
        {



            bool y = true;
            foreach (Urun ur in TemizlikUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == t.Ayrinti.UrunKodu)
                {
                    y = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + t.Ayrinti.UrunAdet;
                }

            }


            if (y == true)
            {
                TemizlikUrunlerListesi.Remove(t);
                y = true;

            }


        }


        public void IndirimUrunCikar(Urun i)
        {



            bool z = true;
            foreach (Urun ur in IndirimUrunlerListesi)
            {

                if (ur.Ayrinti.UrunKodu == i.Ayrinti.UrunKodu)
                {
                    z = false;
                    ur.Ayrinti.UrunAdet = ur.Ayrinti.UrunAdet + i.Ayrinti.UrunAdet;
                }

            }


            if (z == true)
            {
                IndirimUrunlerListesi.Remove(i);
                z = true;

            }

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


        public string TemizlikUrunListele()
        {
            string mesaj = "";
            foreach (Urun t in TemizlikUrunlerListesi)
            {
                {
                    mesaj += "\n Ürün Kodu: " + t.Ayrinti.UrunKodu.ToString() +
                             " Ürün Adı: " + t.Ayrinti.Ad +
                             " Ürün Fiyatı: " + t.Ayrinti.Fiyatı.ToString();
                }

            }
            return mesaj;
        }

        public string IndirimUrunListele()
        {
            string mesaj = "";
            foreach (Urun i in IndirimUrunlerListesi)
            {
                {
                    mesaj += "\n Ürün Kodu: " + i.Ayrinti.UrunKodu.ToString() +
                             " Ürün Adı: " + i.Ayrinti.Ad +
                             " Ürün Fiyatı: " + i.Ayrinti.Fiyatı.ToString();
                }

            }
            return mesaj;
        }

        public Magaza()
        {
            this.GidaUrunlerListesi = new List<Urun>();
            Urun G1 = new Urun();
            G1.Ayrinti.UrunKodu = 001;
            GidaUrunlerListesi.Add(G1);


        }


    }
}
