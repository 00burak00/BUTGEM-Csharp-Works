using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_kalitim
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Arac a1 = new Arac();
            //Araba kamilin_arabasi = new Araba();
            Subaru x = new Subaru();
            //x.Motor_gucu = 1800;
            //x.Renk = "mavi";
            Subaru ahmetin_subarusu = new Subaru("impreza", 2010, "sedan", "dizel", "mavi", 1800, 0);
        }
    }
}