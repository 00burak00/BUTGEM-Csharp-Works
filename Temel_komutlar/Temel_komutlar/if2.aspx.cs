using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class if2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte not_degeri = Convert.ToByte(not_txt.Text);
            if (not_degeri >= 0 && not_degeri <= 100)
            {
                if (not_degeri >= 50) Response.Write("Geçtiniz");
                else Response.Write("kaldınız");
            }//1.if
            else
            {
                Response.Write("not degeri 0 ila 100 arasında olmalı");
            }
        }

  
    }
}