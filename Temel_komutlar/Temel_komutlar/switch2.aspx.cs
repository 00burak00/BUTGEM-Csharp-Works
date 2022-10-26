using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class switch2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sehir_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce_listesi.Items.Clear();
            int plaka = Convert.ToInt32(sehir_listesi.SelectedItem.Value);
            switch (plaka)
            {
                case 16:
                    ilce_listesi.Items.Add("kestel");
                    ilce_listesi.Items.Add("gürsu");
                    ilce_listesi.Items.Add("osmangazi");
                    break;
                case 6:
                    ilce_listesi.Items.Add("ulus");
                    ilce_listesi.Items.Add("polatlı");
                    ilce_listesi.Items.Add("etimesgut");
                    break;
                case 34:
                    ilce_listesi.Items.Add("şişli");
                    ilce_listesi.Items.Add("pendik");
                    ilce_listesi.Items.Add("kartal");
                    break;
            }
            
        }

        protected void ilce_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Seçtiğniz ilçe=" + ilce_listesi.SelectedValue);
        }
    }
}