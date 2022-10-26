using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dogrulama_Kontrolleri
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid == true)
            {
                ///veritabanına kayıt kodları
                Response.Write("işlem tamam");
            }
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dogtar_txt.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (sifre1_txt.Text.Length < 8) args.IsValid = false;//sayfa doğrulamasıda false
        }
    }
}