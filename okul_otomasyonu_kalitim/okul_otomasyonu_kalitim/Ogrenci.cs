using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace okul_otomasyonu_kalitim
{
    public class Ogrenci:Kisi 
    {
        private int ogno;
        private string bolum_adi;

        public int Ogno { get => ogno; set => ogno = value; }
        public string Bolum_adi { get => bolum_adi; set => bolum_adi = value; }

        public string ogrenci_bilgisi()
        {
            return kisi_bilgisi() + "ogrenci no=" + ogno + "Bolumadi=" + bolum_adi;
        }
    }
}