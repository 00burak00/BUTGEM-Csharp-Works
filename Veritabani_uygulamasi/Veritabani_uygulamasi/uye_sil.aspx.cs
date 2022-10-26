using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veritabani_uygulamasi
{
    public partial class uye_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int uye_id = Convert.ToInt32(Request.QueryString["uyeid"]);
            new Uyeler_dao().uye_sil(uye_id);
            Response.Redirect("uye_goster.aspx");
        }
    }
}