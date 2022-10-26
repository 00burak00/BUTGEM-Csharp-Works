using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace text_dosya_islemleri
{
    public class urun
    {
        private int barkod;
        private string urun_adi;
        private int fiyat;
        private int kateno;

        public int Barkod { get => barkod; set => barkod = value; }
        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int Kateno { get => kateno; set => kateno = value; }
        public override string ToString()
        {
       HttpContext.Current.Server.MapPath("");
            return "Urun barkod=" + barkod + "Adı=" + urun_adi + "fiyat=" + fiyat + "kategori no=" + kateno ;
        }
        public string text_veri_hazirla()
        {
            return barkod + ":" + urun_adi + ":" + fiyat + ":" + kateno;
        }
    }
}