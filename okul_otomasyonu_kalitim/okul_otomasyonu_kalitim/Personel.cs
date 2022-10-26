using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace okul_otomasyonu_kalitim
{
    public class Personel:Kisi
    {
        private int perno;
        private string brans;

        public int Perno { get => perno; set => perno = value; }
        public string Brans { get => brans; set => brans = value; }
        public string personel_bilgisi()
        {
            return kisi_bilgisi() + "Personel no=" + perno + "Branşı=" + brans;
        }
    }
}