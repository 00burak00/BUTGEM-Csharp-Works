using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Personel_kayit_sistemi
{
    public class Bolum
    {
        private int bol_no;
        private string bol_adi;
        private string bol_sefi;

        public int Bol_no {  set => bol_no = value; }
        public string Bol_adi {  set => bol_adi = value; }
        public string Bol_sefi {  set => bol_sefi = value; }

        public string bolum_bilgisi()
        {
            return "bolum no" + bol_no + "bolum adi=" + bol_adi + "Şef=" + bol_sefi;
        }
    }
}