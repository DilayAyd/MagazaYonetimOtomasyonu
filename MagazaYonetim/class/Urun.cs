using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaYonetim
{
    public class Urun
    {
        public UrunAyrinti Ayrinti = new UrunAyrinti();

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", Ayrinti.Ad, Ayrinti.Fiyatı, "TL");
        }
    }

}
