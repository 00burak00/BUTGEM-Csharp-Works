using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session_sepet_uygulamasi
{
    public class Urun
    {
        private string urun_adi;
        private int fiyat;
        private string resim;
        private int adet;

        public Urun(string urun_adi, int fiyat, string resim, int adet)
        {
            this.urun_adi = urun_adi;
            this.fiyat = fiyat;
            this.resim = resim;
            this.adet = adet;
        }

        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public string Resim { get => resim; set => resim = value; }
        public int Adet { get => adet; set => adet = value; }

        public override string ToString()
        {
            return "Urun adi" + urun_adi + "fiyatı=" + fiyat + "adet" + adet;
        }
    }
}