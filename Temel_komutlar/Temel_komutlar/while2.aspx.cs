using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class while2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i<=1000)
            {
                DropDownList1.Items.Add(i.ToString());
                i++;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<table border=2>");

            //string yazilacak = kelime_txt.Text;
           // int kac_kez = Convert.ToInt32(DropDownList1.SelectedValue);
            int i = 0;
            while (i<Convert.ToInt32 (DropDownList1.SelectedValue))
            {
                i++;
                Response.Write("<tr><td>" + i + "</td><td>" + kelime_txt.Text + "</td></tr>");
               
            }

            Response.Write("</table>");
        }
    }
}