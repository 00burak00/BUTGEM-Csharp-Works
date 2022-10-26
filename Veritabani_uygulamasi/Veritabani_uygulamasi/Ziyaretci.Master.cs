using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veritabani_uygulamasi
{
    public partial class Ziyaretci : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adsoyad"]!=null)
            {
                Label1.Text = "Hoşgeldiniz" + Session["adsoyad"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Uye uyem = new Uyeler_dao().uye_giris_kontrol(kuladi_txt.Text, sifre_txt.Text);
            if (uyem == null)
            {
                Label1.Text = "Böyle bir üye yok ve yanlış bilgi girildi";
            }
            else
            {
                Label1.Text = "Hoşgeldiniz" + uyem.Adsoyad;
                Session["adsoyad"] = uyem.Adsoyad;
                Session["uyem"] = uyem;
            }
        }
    }
}