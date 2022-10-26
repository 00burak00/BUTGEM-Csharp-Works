using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oop_kalitim
{
    public class Subaru:Araba
    {
        private string model;
        private int model_yili;
        public Subaru()
        {

        }

        public Subaru(string model, int model_yili, string kasa_tipi, string yakit_tipi,
            string renk, int motor_gucu, int anlik_hiz)
            :base(kasa_tipi,yakit_tipi,renk,motor_gucu,anlik_hiz)
        {
            this.model = model;
            this.model_yili = model_yili;
        }

        public string Model { get => model; set => model = value; }
        public int Model_yili { get => model_yili; set => model_yili = value; }
        public string subaru_bilgisi()
        {
            return araba_bilgisi() + "model=" + model + "model yılı=" + model_yili;
        }
    }
}