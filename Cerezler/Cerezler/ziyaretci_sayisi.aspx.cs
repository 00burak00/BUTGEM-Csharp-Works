using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cerezler
{
    public partial class ziyaretci_sayisi : System.Web.UI.Page
    {
          protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("ziyaret");
            if (Session["ziyaret_kontrol"]==null)
            {
                if (Request.Cookies["ziyaret"] == null)//ilk ziyaret
                {
                    Response.Write("Sitemizi ilk ziyaretiniz umarım beğinirsin");
                    cerez["ziy_sayi"] = "1";
                }
                else //daha sonraki ziyaretler
                {
                    cerez = Request.Cookies["ziyaret"];
                    int ziy_sayi = Convert.ToInt32(cerez["ziy_sayi"]);
                    ziy_sayi++;
                    Response.Write("Sitemizi" + ziy_sayi + "ziyaretiniz");
                    cerez["ziy_sayi"] = ziy_sayi.ToString();
                }//else
                cerez.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerez);
                Session["ziyaret_kontrol"] = "ok";
            }//session ifi
            else
            {
                cerez = Request.Cookies["ziyaret"];
                int ziy_sayi = Convert.ToInt32(cerez["ziy_sayi"]);
                Response.Write("Sitemizi" + ziy_sayi + "ziyaretiniz");
            }
        }
    }
}