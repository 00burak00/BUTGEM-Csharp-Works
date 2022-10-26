using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_siniflar
{
    public partial class Hesaplama_sayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
           //int sonuc= islem.toplama(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            //Response.Write(sonuc);
            int[] dizim = { 56, 85, 78, 96, 74, 77 };
            Response.Write(islem.coklu_toplama(dizim));
        }
    }
}