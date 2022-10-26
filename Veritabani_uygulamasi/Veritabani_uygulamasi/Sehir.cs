using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Sehir
    {
        private byte plaka;
        private string sehiradi;

        public Sehir(byte plaka, string sehiradi)
        {
            this.plaka = plaka;
            this.sehiradi = sehiradi;
        }

        public byte Plaka { get => plaka; set => plaka = value; }
        public string Sehiradi { get => sehiradi; set => sehiradi = value; }
    }
}