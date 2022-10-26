using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ogrenci_not_sistemi
{
    public class Ogrenci
    {
        private int ogno;
        private String ad_soyad;
        private String adres;
        private int not1;
        private int not2;
        public int Ogno { get => ogno; set => ogno = value; }
        public string Ad_soyad {set => ad_soyad = value; }
        public string Adres { set => adres = value; }
        public int Not1 {  set => not1 = value; }
        public int Not2 {  set => not2 = value; }
        
        private string not_hesapla()
        {
            int ort = (not1 + not2) / 2;
            if (ort >= 50) return ort + "ile geçti";
            else return ort + "ile kaldı";
        }
        public string ogrenci_bilgisi()
        {
            return "numara=" + ogno + "adsoyad=" + ad_soyad + "adres=" + adres +
                "not1=" + not1 + "not2=" + not2 + "  " + not_hesapla();
        }
    }
}