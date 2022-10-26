using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_siniflar
{
    public class Urun
    {
        public int barkodno;
        public double fiyat;
        public String kateadi;
        public String urun_adi;

        public String urun_bilgisi()
        {
            return "Ürün barkodu=" + barkodno + "adı=" + urun_adi + "fiyatı=" + fiyat + "Kategorisi=" + kateadi;
        }
    }
}