using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace oop_compositıon
{
    public class Ogrenci
    {
        private int ogno;
        private string adsoyad;
        private Adres ikamet_adresi;
        private Adres memleket_adresi;

        public int Ogno { get => ogno; set => ogno = value; }
        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public Adres Ikamet_adresi { get => ikamet_adresi; set => ikamet_adresi = value; }
        public Adres Memleket_adresi { get => memleket_adresi; set => memleket_adresi = value; }
       
        public String ogrencibilgisi()
        {
            return "Öğrenci no=" + ogno + "Adsoyad=" + adsoyad
                + "İkmet adresi=" + ikamet_adresi.adres_bilgisi()
                + "memleket adresi=" + memleket_adresi.adres_bilgisi();
        }
    
    }
}