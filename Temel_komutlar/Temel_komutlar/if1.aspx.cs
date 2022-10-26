using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class if1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String kuladi = kuladitxt.Text;
            String sifre = sifre_txt.Text;
            if (kuladi == "Admin" && sifre == "12345")
            {
                Response.Write("giriş başarılı");
            }//if
            else Response.Write("kullanıcı veya şifre hatalı");
        }//click
    }
}