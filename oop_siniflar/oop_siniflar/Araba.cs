namespace oop_siniflar
{
    public class Araba
    {
        //global
        private string renk;

        public void SetRenk(string renk)
        {
            this.renk = renk;
        }

        public string GetRenk()
        {
            return renk;
        }
        private int motor_gucu;

        private int anlik_hiz;

        private string yakit_tipi;

        public int Motor_gucu
        { get => motor_gucu; 
         set => motor_gucu = value; }
        public string Yakit_tipi
        { get => yakit_tipi; 
            set => yakit_tipi = value; }
        public int Anlik_hiz 
        { get => anlik_hiz;
           }

        public Araba ()//void 
        {
            //nesne oluşurken çalışmasını istediğim kodlar burda
            renk = "mavi";
            
        }
      
         public Araba (string yakit_tipi,int motor_gucu)
        {
            this.Yakit_tipi = yakit_tipi;
            this.Motor_gucu = motor_gucu;
        }

        public Araba (int hiz,string yakit)
        {
            this.yakit_tipi = yakit;
            anlik_hiz = hiz;
        }


        public void hizlan()
        {
            anlik_hiz += 10;
        }

        public void hizlan(int km)
        {
            anlik_hiz += km;
        }

    

        public void frenyap(int km)
        {
            anlik_hiz -= km;
        }

        public string araba_bilgisi()
        {

            string sonuc = "Renk=" + renk + "motor gücü=" + Motor_gucu
                  + "Yakıt tipi=" + Yakit_tipi + "şu anki hız=" + Anlik_hiz;
            return sonuc;
        }
    }//class
}