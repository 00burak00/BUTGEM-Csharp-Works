using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace kirtasiye_otomasyon_kalitim
{
    public class Tedarikci
    {
        private string ted_adi;
        private string ted_tel;

        public string Ted_adi { set => ted_adi = value; }
        public string  Ted_tel {  set => ted_tel = value; }

        public string  Tedarikci_bilgisi()
        {
            return "Tedarikçi adı=" +ted_adi + "Tel=" + ted_tel;
        }
    }
}