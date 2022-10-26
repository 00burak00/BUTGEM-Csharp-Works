using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace okul_otomasyonu_kalitim
{
    public class Kisi
    {
        private long tckimlik;
        private string ad_soyad;
        private string ana_adi;
        private Adres adres;

        public long Tckimlik { get => tckimlik; set => tckimlik = value; }
        public string Ad_soyad { get => ad_soyad; set => ad_soyad = value; }
        public string Ana_adi { get => ana_adi; set => ana_adi = value; }
        public Adres Adres { get => adres; set => adres = value; }
        public string kisi_bilgisi()
        {
            return "Tckimlik=" + tckimlik + "adsoyad=" + ad_soyad + "ana adı=" + ana_adi
                + "Adres=" + adres.adres_bilgisi();
        }
    }
}