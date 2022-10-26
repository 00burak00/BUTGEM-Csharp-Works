using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Urun
    {
        private int urunid;
        private string urunadi;
        private double fiyat;
        private string aciklama;
        private string resim;
        private Kategori kateno;

        public int Urunid { get => urunid; set => urunid = value; }
        public string Urunadi { get => urunadi; set => urunadi = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
        public string Resim { get => resim; set => resim = value; }
        public Kategori Kateno { get => kateno; set => kateno = value; }
    }
}