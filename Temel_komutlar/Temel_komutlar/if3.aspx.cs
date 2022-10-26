using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class if3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte notdegeri = Convert.ToByte(not_txt.Text);
            if (notdegeri >= 0 && notdegeri <= 100)
            {
                if (notdegeri >= 0 && notdegeri <= 24) Response.Write("not karşılığı 0");
                else if (notdegeri >= 25 && notdegeri <= 44) Response.Write("not karşılığı 1");
                else if (notdegeri >= 45 && notdegeri <= 54) Response.Write("not karşılığı 2");
                else if (notdegeri >= 55 && notdegeri <= 69) Response.Write("not karşılığı 3");
                else if (notdegeri >= 70 && notdegeri <= 84) Response.Write("not karşılığı 4");
                else Response.Write("not karşılığı 5");
            }//1. 0 100 kontrol if
            else Response.Write("not degeri 0 ile 100 arasında olmalı");
        }
    }
}