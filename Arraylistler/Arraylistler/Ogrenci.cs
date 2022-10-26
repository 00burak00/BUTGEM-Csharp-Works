using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arraylistler
{
    public class Ogrenci
    {
        private int ogno;
        private String ad_soyad;
        private String adres;

        public int Ogno { get => ogno; set => ogno = value; }
        public string Ad_soyad {set => ad_soyad = value; }
        public string Adres { set => adres = value; }



        public override string ToString()
        {
            return "numara=" + ogno + "adsoyad=" + ad_soyad + "adres=" + adres;
        }
           
                
     
    }
}