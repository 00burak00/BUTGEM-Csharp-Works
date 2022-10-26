using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Sepetlik
    {
        private Urun urunum;
        private int adet;

        public int Adet { get => adet; set => adet = value; }
        public Urun Urunum { get => urunum; set => urunum = value; }
    }
}