using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_sepet_uygulamasi
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Application["top_ziy"] == null)
                {
                    Application["top_ziy"] = "1";
                    Label1.Text = "toplam ziyaretçi sayısı=1";
                }
                else
                {
                    int top_ziy = Convert.ToInt32(Application["top_ziy"]);
                    top_ziy += 1;
                    Label1.Text = "toplam ziyaretçi sayısı=" + top_ziy;
                    Application["top_ziy"] = top_ziy;

                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (kuladi_txt.Text.Equals("abdullah") && sifre_txt.Text.Equals("12345"))
            {
                Session["kuladi"] = "abdullah";
                Response.Redirect("urunler.aspx");
            }
            else Label1.Text = "Yanlış kullanıcı adı veya şifre";

        }
    }
}