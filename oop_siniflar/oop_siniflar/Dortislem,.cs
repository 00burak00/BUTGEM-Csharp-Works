using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_siniflar
{
    public class Dortislem_
    {
        public int sayi1;
        public int sayi2;
        public byte secim;
        public double islemyap()
        {
            double sonuc = 0;
            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = sayi1 / sayi2;
                    break;
            }//swi
            return sonuc;
        }
       
    }
}