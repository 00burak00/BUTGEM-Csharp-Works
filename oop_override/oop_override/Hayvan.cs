using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_override
{
    public class Hayvan
    {
        private string adi;
        private int yas;
        private string renk;

        public string Adi { get => adi; set => adi = value; }
        public int Yas { get => yas; set => yas = value; }
        public string Renk { get => renk; set => renk = value; }

        public void kos()
        {
            //koşma komutları
        }
        public virtual string sescikar()
        {
            return "sesim belli değil";
        }
    }
}