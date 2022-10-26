using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class Dizi_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String[] arabalar = new String[5];
            arabalar[0] = "porş";
            arabalar[1] = "reno";
            arabalar[2] = "fiat";
            arabalar[4] = "nissan";
            //Response.Write(arabalar[2]);
            /* for (int i=0;i<arabalar.Length;i++)
             {
                 Response.Write(arabalar[i]+ "<br>");
             }*/

            //Array.Reverse(arabalar);
            //Array.Sort(arabalar);
           /* int indexi=Array.IndexOf(arabalar, "opel");
            if (indexi != -1) Response.Write("Bu araba var");
            else Response.Write("bu araba yok");*/
           /*foreach( String araba in  arabalar)
            {
                Response.Write(araba+ "<br>");
            }*/

        }
    }
}