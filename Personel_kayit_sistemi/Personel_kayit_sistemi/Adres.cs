using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Personel_kayit_sistemi
{
    public class Adres
    {
        private string  ilce;
        private string mahalle;
        private int apt_no;

        public string Ilce { set => ilce = value; }
        public string Mahalle {set => mahalle = value; }
        public int Apt_no { set => apt_no = value; }

        public string adres_bilgisi()
        {
            return "ilce=" + ilce + "mahalle=" + mahalle + "apt numara=" + apt_no; 
        }
    }
}