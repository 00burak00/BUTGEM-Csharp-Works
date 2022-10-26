using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Personel_kayit_sistemi
{
    public class Personel
    {
        private int sgkno;
        private string ad_soyad;
        private int kidem_yili;
        private Adres adres;
        private Bolum bolum;
        private int maas;

        public int Sgkno { get => sgkno; set => sgkno = value; }
        public string Ad_soyad {  set => ad_soyad = value; }
        public int Kidem_yili {  set => kidem_yili = value; }
        public Adres Adres {set => adres = value; }
        public Bolum Bolum { set => bolum = value; }
        public int Maas { get => maas;  }

        public string personel_bilgisi()
        {
            return "Personel kişisel verileri sgkno=" + sgkno + "ad soyad=" + ad_soyad
                 + "Maaş=" + maas + "adres=" + adres.adres_bilgisi()
                 + "Bolum bilgisi=" + bolum.bolum_bilgisi();
        }

        public void maas_hesapla()
        {
            maas = 5000 + kidem_yili * 250;
        }
    }
}