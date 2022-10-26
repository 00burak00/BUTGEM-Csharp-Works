using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arraylist_vt_ornek
{
    public class Urunislemleri : IUrunislemleri
    {
        private ArrayList urunlerim;

        public Urunislemleri()
        {
           urunlerim= new Veritabani().Urunlerim;//veritabanı class nesne oluşturduk ve içindeki urunlerim array listini aldık
        }

        public Urun urunbul(int urunid)
        {
            Urun geri_donecek_urun = null;
            foreach (Urun varolan_urun in urunlerim)
            {
                if (varolan_urun.Urunid == urunid)
                {
                    geri_donecek_urun = varolan_urun;
                    break;//buldu bulunca duralım
                }
            }
            return geri_donecek_urun;
        }

        public ArrayList urunlerigetir()
        {
            return urunlerim;
        }

        public void Urun_kaydet(Urun yeniurun)
        {
            urunlerim.Add(yeniurun);
        }

        public bool Urun_sil(int urunid)
        {
            bool kontrol = false;
            int index = -1;
            foreach (Urun varolan_urun in urunlerim)
            {
                index++;
                if (varolan_urun.Urunid == urunid)
                {
                    kontrol = true;//silinecek ürün bulundu 
                    break;
                }

            }
            if (kontrol==true)  urunlerim.RemoveAt(index);//ürünü bulduysa silecek
            return kontrol;
        }
    }
}