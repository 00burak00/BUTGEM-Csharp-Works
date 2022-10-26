using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_kalitim
{
    public class Araba:Arac
    {
        private String kasa_tipi;
        private String yakit_tipi;

        public Araba ()
        {

        }
        public Araba(string kasa_tipi, string yakit_tipi, 
            string renk, int motor_gucu, int anlik_hiz):base(renk,motor_gucu,anlik_hiz)
        {
            this.kasa_tipi = kasa_tipi;
            this.yakit_tipi = yakit_tipi;
        }

        public string Kasa_tipi { get => kasa_tipi; set => kasa_tipi = value; }
        public string Yakit_tipi { get => yakit_tipi; set => yakit_tipi = value; }
        public string araba_bilgisi()
        {
            return  arac_bilgisi()+ "Kasa tipi=" + kasa_tipi + "Yakıt=" + yakit_tipi;
        }
    }
}