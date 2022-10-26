using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace Arraylist_vt_ornek
{
    
    public class Veritabani
    {
        private ArrayList urunlerim;

        public ArrayList Urunlerim { get => urunlerim; }

        public Veritabani()
        {
            urunlerim = new ArrayList();
            Urun ur1 = new Urun("ram", 80, 1);
            Urun ur2 = new Urun("hdd", 280, 3);
            Urun ur3 = new Urun("monitör", 480, 2);
            Urun ur4 = new Urun("cpu", 180, 10);
            urunlerim.Add(ur1);
            urunlerim.Add(ur2);
            urunlerim.Add(ur3);
            urunlerim.Add(ur4);
        }
    }
}