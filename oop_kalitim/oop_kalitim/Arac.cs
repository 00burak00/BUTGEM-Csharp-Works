using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_kalitim
{
    public class Arac
    {
        private String renk;
        private int motor_gucu;
        private int anlik_hiz;

        public Arac ()
        {

        }
        public Arac(string renk, int motor_gucu, int anlik_hiz)
        {
            this.renk = renk;
            this.motor_gucu = motor_gucu;
            this.anlik_hiz = anlik_hiz;
        }

        public string Renk { get => renk; set => renk = value; }
        public int Motor_gucu { get => motor_gucu; set => motor_gucu = value; }
        public int Anlik_hiz { get => anlik_hiz; set => anlik_hiz = value; }

        public void hizlan(int km) { anlik_hiz += km; }
        public void fren_yap(int km) { anlik_hiz -= km; }

        public string arac_bilgisi()
        {
            return "renk=" + renk + "motorgücü" + motor_gucu + "anlik hiz=" + anlik_hiz;
        }

    }
}