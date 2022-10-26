using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace viewstate_durum
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "16":
                    ListBox1.Items.Add("kestel");
                    ListBox1.Items.Add("yıldırım");
                    ListBox1.Items.Add("nilüfer");
                    ListBox1.Items.Add("gürsu");
                    break;
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(ListBox1.SelectedValue);
        }
    }
}