using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class Sehir_mvc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList sehir_listesi = new Sehirler_dao().tum_sehirleri_getir();
            int i = 1;
            foreach (Sehir gelen_sehir in sehir_listesi)
            {
                DropDownList1.Items.Add(gelen_sehir.Sehiradi);
                DropDownList1.Items[i].Value = gelen_sehir.Plaka.ToString ();
                i++;
            }
        }
    }
}