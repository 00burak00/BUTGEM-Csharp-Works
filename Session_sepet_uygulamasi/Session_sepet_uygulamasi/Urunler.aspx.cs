using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_sepet_uygulamasi
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kuladi"] == null)
            {
                Response.Write("bu sayfayı sadece giriş yapanlar görebilir");
                Response.End();
            }
            else
                Response.Write("Hoşgeldiniz" + Session["kuladi"]);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["kateno"] = RadioButtonList1.SelectedValue;
            Response.Redirect("urundetay.aspx");
        }
    }
}