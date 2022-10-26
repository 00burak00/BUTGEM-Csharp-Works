using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request_nesnesi
{
    public partial class Urunlerimiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte urunid = Convert.ToByte(Request.QueryString["urunid"]);
            switch (urunid)
            {
                case 1:
                    Image1.ImageUrl = "img/ana.jpg";
                    Label1.Text = "1500 Tl";
                    break;
                case 2:
                    Image1.ImageUrl = "img/ram.jpg";
                    Label1.Text = "500 Tl";
                    break;
                case 3:
                    Image1.ImageUrl = "img/hdd.jpg";
                    Label1.Text = "3500 Tl";
                    break;
            }
        }
    }
}