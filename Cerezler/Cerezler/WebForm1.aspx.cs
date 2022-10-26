using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cerezler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HttpCookie cerezim = new HttpCookie("bilgi");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {  
            cerezim["ad"] = "tuncay";
            cerezim["yas"] = "45";
            cerezim.Expires = DateTime.Now.AddMonths(2);
            Response.Cookies.Add(cerezim);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["bilgi"] != null)
            {
                cerezim = Request.Cookies["bilgi"];
                Response.Write(cerezim["ad"] + cerezim["yas"]);
            }
            else Response.Write("çerez yok");
        }
    }
}