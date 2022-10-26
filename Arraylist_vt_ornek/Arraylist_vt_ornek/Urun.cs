using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Arraylist_vt_ornek
{
    public class Urun
    {
        private string urunadi;
        private int fiyat;
        private int urunid;

        public Urun()
        {
        }

        public Urun(string urunadi, int fiyat, int urunid)
        {
            this.urunadi = urunadi;
            this.fiyat = fiyat;
            this.urunid = urunid;
        }

        public string Urunadi { get => urunadi; set => urunadi = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int Urunid { get => urunid; set => urunid = value; }

        public override string ToString()
        {
            return "Ürün no=" + urunid + "Ürün adı=" + urunadi + "Fiyatı=" + fiyat;

        }
        
    }
}