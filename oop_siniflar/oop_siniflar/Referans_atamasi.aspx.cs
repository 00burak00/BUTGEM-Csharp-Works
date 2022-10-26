using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_siniflar
{
    public partial class Referans_atamasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Araba a1 = new Araba();
            a1.SetRenk("beyaz");
            a1.Motor_gucu = 2500;
            a1.Yakit_tipi = "dizel";
            Response.Write("a1="+a1.araba_bilgisi()+"<br>");
            Araba a2 = a1;
            Response.Write("a2=" + a2.araba_bilgisi() + "<br>");
            a2.SetRenk("mavi");
            a2.Motor_gucu = 3500;
            Response.Write("a2=" + a2.araba_bilgisi()+"<br>");
            Response.Write("a1=" + a1.araba_bilgisi() + "<br>");
        }
    }
}