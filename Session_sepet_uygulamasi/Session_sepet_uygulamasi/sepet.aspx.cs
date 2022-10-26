using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Session_sepet_uygulamasi
{
    public partial class sepet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList musteri_sepet = (ArrayList)Session["sepet"];
            Response.Write("<table border=1>");
            int sepet_top = 0;
            if (Session["sepet"] != null)
            {
                foreach (Urun sepetteki_urun in musteri_sepet)
                {
                    Response.Write("<tr><td>" + sepetteki_urun.Urun_adi + "</td><td>" + sepetteki_urun.Fiyat +
                        "</td><td>" + sepetteki_urun.Adet + "</td><td><img src=" + sepetteki_urun.Resim
                        + " height=100 width=100></td></tr>");
                    sepet_top += sepetteki_urun.Fiyat * sepetteki_urun.Adet;
                }
                Response.Write("</table>");
                Label1.Text = "Sepet toplamı=" + sepet_top;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("sepet.aspx");
        }
    }
}