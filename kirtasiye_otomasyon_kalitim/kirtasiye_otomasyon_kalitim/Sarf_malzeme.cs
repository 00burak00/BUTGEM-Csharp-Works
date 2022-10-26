using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace kirtasiye_otomasyon_kalitim
{
    public class Sarf_malzeme:Kirtasiye
    {
        private string tur;

        public string Tur {  set => tur = value; }

        public string sarf_mlz_bilgisi()
        {
            return "sarf malzeme bilgisi=" + urun_bilgisi() + "Türü=" + tur;
        }
    }
}