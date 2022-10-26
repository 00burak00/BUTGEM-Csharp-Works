using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Applications
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["top_ziy"] == null)
            { Application["top_ziy"] = "1";
                Response.Write("toplam ziyaretçi sayısı=1"); }
            else
            {
                int top_ziy =Convert.ToInt32( Application["top_ziy"]);
                top_ziy += 1;
                Response.Write("toplam ziyaretçi sayısı=" + top_ziy);
                Application["top_ziy"] = top_ziy;

            }
        }
    }
}