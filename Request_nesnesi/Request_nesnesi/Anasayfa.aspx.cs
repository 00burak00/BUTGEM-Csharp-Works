using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_nesnesi
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HyperLink yeni_link = new HyperLink()
            {
                Text = "urunadi",
                NavigateUrl = "urunlerimiz.aspx?urunid=",
                
            };
            Page.Controls.Add(yeni_link);
        }
    }
}