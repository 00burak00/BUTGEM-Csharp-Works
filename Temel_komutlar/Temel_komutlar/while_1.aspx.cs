using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class while_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int top = 0;
            int sayac = 0;
            while (sayac<=100)
            {
                top += sayac;
                sayac += 2;
            }//while
            Response.Write("toplam=" + top);
        }
    }
}