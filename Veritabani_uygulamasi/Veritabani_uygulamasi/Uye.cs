using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veritabani_uygulamasi
{
    public class Uye
    {
        private int uyeid;
        private string kuladi;
        private string sifre;
        private string adsoyad;
        private DateTime dogtar;
        private bool cinsiyet;
        private string adres;
        private string email;
        private bool onay;
        private Sehir sehir;
        private Meslek meslek;

        public Uye()
        {
        }

        public Uye(int uyeid, string kuladi, string sifre, string adsoyad, DateTime dogtar, bool cinsiyet, string adres, string email, bool onay, Sehir sehir, Meslek meslek)
        {
            this.uyeid = uyeid;
            this.kuladi = kuladi;
            this.sifre = sifre;
            this.adsoyad = adsoyad;
            this.dogtar = dogtar;
            this.cinsiyet = cinsiyet;
            this.adres = adres;
            this.email = email;
            this.onay = onay;
            this.sehir = sehir;
            this.meslek = meslek;
        }

        public int Uyeid { get => uyeid; set => uyeid = value; }
        public string Kuladi { get => kuladi; set => kuladi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public DateTime Dogtar { get => dogtar; set => dogtar = value; }
        public bool Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
        public bool Onay { get => onay; set => onay = value; }
        public Sehir Sehir { get => sehir; set => sehir = value; }
        public Meslek Meslek { get => meslek; set => meslek = value; }
    }
}