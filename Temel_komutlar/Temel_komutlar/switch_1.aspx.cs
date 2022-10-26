using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class switch_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte notdegeri = Convert.ToByte(not_txt.Text);
          
                switch (notdegeri)
                {
                    case 5:
                        Response.Write("pekiyi");
                        break;
                    case 4:
                        Response.Write("iyi");
                        break;
                    case 3:
                        Response.Write("orta");
                        break;
                    case 2:
                        Response.Write("Geçer");
                        break;
                    default:
                        if (notdegeri == 0 || notdegeri == 1) Response.Write("kaldın");
                        else Response.Write("girilen not geçersiz 0-5 aralığında değer girin");
                        break;

                }//switch
           
        }
    }
}