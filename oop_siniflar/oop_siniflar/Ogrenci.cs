using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_siniflar
{
    public class Ogrenci
    {
        public int ogno;
        public string ad_soyad;
        public string adres;
     
        public string ogrenci_bilgisi()
        {
            return "Öğrenci no=" + ogno + "Adsoyad=" + ad_soyad + "Adres=" + adres;
        }

        public string not_hesapla(string dersadi,int[] notlar)
        {
            string sonuc;
            int top=0,sayac=0;
            foreach ( int gelennot    in notlar)
            {
                if (gelennot != 0)
                {
                    top += gelennot;
                    sayac++;
                }
            }//for iç
            int ort = top / sayac;
            if (ort>=50) 
                sonuc=ogrenci_bilgisi ()+ " öğrencisi" + ort + "ort ile " + dersadi + "dersinden geçti";
            else
                sonuc = ogrenci_bilgisi() + " öğrencisi" + ort + "ort ile " + dersadi + "dersinden kaldı";
            return sonuc;
        }
    }
}