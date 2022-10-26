using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Elma el = new Elma();
            Amasya_elmasi amasya = new Amasya_elmasi();
            Elma a = new Amasya_elmasi();
            //IYenilebilir u = new Elma();
            Tavuk tav = new Tavuk();
            Aslan ar= new Aslan();

            object[] objeler = new object[5];
            objeler[0] = el;
            objeler[1] = amasya;
            objeler[2] = a;
            objeler[3] = tav;
            objeler[4] = ar;
            foreach (object nesne in objeler)
            {
            if(nesne is IYenilebilir) Response.Write( ((IYenilebilir)nesne).nasil_yenilir() +"<br>");
             if(nesne is ISuyucikarilabilir) Response.Write(((ISuyucikarilabilir)nesne).nasil_suyu_cikarilir()+"<br>");

            }
        }
    }
}