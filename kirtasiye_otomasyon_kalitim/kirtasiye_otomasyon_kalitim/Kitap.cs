using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace kirtasiye_otomasyon_kalitim
{
    public class Kitap:Kirtasiye
    {
        private string yazaradi;
        private int sayfa_sayisi;

        public string Yazaradi { set => yazaradi = value; }
        public int Sayfa_sayisi { set => sayfa_sayisi = value; }

        public string  kitap_bilgisi()
        {
          return "kitap bilgisi="+urun_bilgisi()+"yazaradi=" +yazaradi + "sayfa sayısı=" + sayfa_sayisi;
        }
    }
}