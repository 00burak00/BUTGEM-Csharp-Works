using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace okul_otomasyonu_kalitim
{
    public class Adres
    {
        private string ilce;
        private string mahalle;
        private int apt_no;
    
        public string Ilce { get => ilce; set => ilce = value; }
        public string Mahalle { get => mahalle; set => mahalle = value; }
        public int Apt_no { get => apt_no; set => apt_no = value; }
        public string adres_bilgisi()
        {
            return  "ilce=" + ilce + "mahalle=" + mahalle + "apartman no=" + apt_no;
        }
    }
}