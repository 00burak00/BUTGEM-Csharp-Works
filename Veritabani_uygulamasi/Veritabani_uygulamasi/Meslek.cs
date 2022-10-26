using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Meslek
    {
        private int meslekid;
        private string meslekad;

        public Meslek(int meslekid, string meslekad)
        {
            this.meslekid = meslekid;
            this.meslekad = meslekad;
        }

        public int Meslekid { get => meslekid; set => meslekid = value; }
        public string Meslekad { get => meslekad; set => meslekad = value; }
    }
}