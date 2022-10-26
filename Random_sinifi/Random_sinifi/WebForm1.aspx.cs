using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Random_sinifi
{
    public partial class WebForm1 : System.Web.UI.Page
    {   protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//sayfa ilk kez yüklendiğinde
            {
                Random uret = new Random();
                String[] harfler = { "A", "B", "D", "E", "V" };
                int birinci_rakam = uret.Next(0, 9);
                Image1.ImageUrl = "img/" + birinci_rakam + ".gif";
                Image4.ImageUrl = "img/" + uret.Next(0, 9) + ".gif";
                Image2.ImageUrl = "img/" + harfler[uret.Next(0, 4)] + ".gif";
                Image3.ImageUrl = "img/" + harfler[uret.Next(0, 4)] + ".gif";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String guvkod = Image1.ImageUrl.Substring(4, 1) +
                Image2.ImageUrl.Substring(4, 1) +
                  Image3.ImageUrl.Substring(4, 1) +
                    Image4.ImageUrl.Substring(4, 1);//3AE8

            if (guv_kod_txt.Text.Equals(guvkod))
            {
                Response.Write("Güvenlik kodu uyuşuyor.Sisteme kayıt yapıldı");
            } else Response.Write("Güvenlik kodu aynı değil");


        }
    }
}