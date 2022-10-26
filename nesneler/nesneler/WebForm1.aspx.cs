using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nesneler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(RadioButtonList1.SelectedValue);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sonuc = "";
           // Response.Write( CheckBoxList1.SelectedValue);
           for (int i=0;i<CheckBoxList1.Items.Count;i++)
            {
                if (CheckBoxList1.Items[i].Selected==true)
                {
                    sonuc += CheckBoxList1.Items[i].Value;
                }
            }
            Response.Write(sonuc);
        }
    }
}