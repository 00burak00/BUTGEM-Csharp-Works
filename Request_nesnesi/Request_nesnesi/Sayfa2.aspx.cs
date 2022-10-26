using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_nesnesi
{
    public partial class Sayfa2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ad = Request.QueryString["ad"];
            int yas = Convert.ToInt32(Request.QueryString["yas"]);
            Response.Write(ad + yas);
        }
    }
}