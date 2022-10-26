using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Kategori
    {
        private int kateno;
        private string kateadi;

        public Kategori()
        {
        }

        public Kategori(int kateno, string kateadi)
        {
            this.kateno = kateno;
            this.kateadi = kateadi;
        }

        public int Kateno { get => kateno; set => kateno = value; }
        public string Kateadi { get => kateadi; set => kateadi = value; }
    }
}