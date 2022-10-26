using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class for3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<table border=2>");

            for (int i = 1; i <= 100; i++)
            {
                Response.Write("<tr><td>Yazılım</td><td>uzmanlığı</td></tr>");
            }
            Response.Write("</table>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<table border=2><tr><td>DERECE</td><td>Fahrenayt</td></tr>");

            for (int derece=0;derece<=100;derece++)
            {
                double fah = derece * 1.8 + 32;
                Response.Write("<tr><td>" + derece + "</td><td>" + fah + "</td></tr>");
            }

            Response.Write("</table>");
        }
    }
}