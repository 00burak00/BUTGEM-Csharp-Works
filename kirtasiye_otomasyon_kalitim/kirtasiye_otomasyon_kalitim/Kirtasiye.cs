using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace kirtasiye_otomasyon_kalitim
{
    public class Kirtasiye
    {
        private long barkod_no;
        private string adi;
        private int fiyat;
        private string resim;
        private Tedarikci tedarikci;

        public long Barkod_no { get => barkod_no; set => barkod_no = value; }
        public string Adi { get => adi; set => adi = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public string Resim { get => resim; set => resim = value; }
        public Tedarikci Tedarikci { get => tedarikci; set => tedarikci = value; }

        public string  urun_bilgisi()
        {
            return "Ürün bilgisi Barkodno=" + Barkod_no + "adi=" + adi + "fiyat=" + Fiyat
                +"Tedarikçi="+Tedarikci.Tedarikci_bilgisi();
        }

        public int  satin_al(int adet)
        {
            return adet * fiyat;
        }
    }
}