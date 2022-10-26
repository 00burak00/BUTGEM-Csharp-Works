using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_siniflar
{
    public partial class Personel_sayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Personel p1 = new Personel();
            p1.Perno = 1;
            p1.Per_ad_soyad = "tuncay";
            
            Personel p2 = new Personel(2, "osman");
            Response.Write("personel sayımız=" + Personel.sayac);

            Response.Write (Personel.maas_yatir(2, 3, 2022, 8500));
        
        }
    }
}