using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_siniflar
{
    public class Personel
    {
        public static int sayac;
        public const int sabit_katsayi = 5;
        private int perno;
        private string per_ad_soyad;
        private long tc_kimlik;
        public Personel ()
        {
            sayac++;
        }
        public Personel(int perno, string per_ad_soyad)
        {
            
            this.perno = perno;
            this.per_ad_soyad = per_ad_soyad;
            sayac++;
            
        }

        public int Perno 
        { get => perno; set => perno = value; }
        public string Per_ad_soyad 
        { get => per_ad_soyad; set => per_ad_soyad = value; }
        public long Tc_kimlik { get => tc_kimlik; set => tc_kimlik = value; }

        public string personel_bilgisi()
        { 
            return "perno=" + perno + "adsoyad=" + per_ad_soyad + "tc=" + tc_kimlik;
        }
        public static string maas_yatir(int perno, int ay, int yil, double maas)
        {
            
            //static metotlardan ancak static değişkenlere ve metotlara erişilir.
            //burda veritabanına kayıt ve eft kodları olacak
            return "maaaş yatırıldı";
        }
    }
}