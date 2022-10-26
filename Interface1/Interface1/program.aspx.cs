using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interface1
{
    public partial class program : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tuncay_efekti t_efekt = new Tuncay_efekti();
            Photoshop_plugin_uygula(t_efekt);
            Canitin c_efekt = new Canitin();
            Photoshop_plugin_uygula(c_efekt);
            Aykut ay = new Aykut();
            Photoshop_plugin_uygula(ay);
        }

        public void Photoshop_plugin_uygula(Photoshop_plugin p)
        {
           

           Response.Write ( p.efekt_uygula());
        }
    }
}