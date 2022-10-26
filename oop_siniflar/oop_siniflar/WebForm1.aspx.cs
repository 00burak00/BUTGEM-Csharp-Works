using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_siniflar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Araba tuncayin_arabasi = new Araba();
            //tuncayin_arabasi.renk = "beyaz";
            tuncayin_arabasi.SetRenk("beyaz");
            Response.Write(tuncayin_arabasi.GetRenk());
            tuncayin_arabasi.Motor_gucu = 1600;
            tuncayin_arabasi.Yakit_tipi = "dizel";
            Response.Write(tuncayin_arabasi.Yakit_tipi);
           
            tuncayin_arabasi.hizlan();
            tuncayin_arabasi.hizlan();
            tuncayin_arabasi.hizlan();
            tuncayin_arabasi.hizlan();
            tuncayin_arabasi.hizlan(50);
            tuncayin_arabasi.frenyap(20);
            tuncayin_arabasi.frenyap(5);

            Araba ismailin_arabasi = new Araba();
           // ismailin_arabasi.renk = "kırmızı";
            ismailin_arabasi.Motor_gucu = 4500;
            ismailin_arabasi.Yakit_tipi = "benzin";
            ismailin_arabasi .hizlan();
           // Response.Write(tuncayin_arabasi.araba_bilgisi());
           // Response.Write(ismailin_arabasi.araba_bilgisi());


            Araba aysenin_arabasi = new Araba("dizel", 1500);
            Response.Write("ayşenin arabası bilgileri=" + aysenin_arabasi.araba_bilgisi());

            /*Response.Write("Tuncayın arabası bilgileri="
                + tuncayin_arabasi.renk + "  " + tuncayin_arabasi.motor_gucu
                + "  " + tuncayin_arabasi.yakit_tipi + "   " + tuncayin_arabasi.anlik_hiz);

            Response.Write("ismail arabası bilgileri="
              + ismailin_arabasi.renk + "  " + ismailin_arabasi.motor_gucu
              + "  " + ismailin_arabasi.yakit_tipi + "   " + ismailin_arabasi.anlik_hiz);*/

            string a = "kamil";
           
        }
    }
}