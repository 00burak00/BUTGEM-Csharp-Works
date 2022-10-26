using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cerezler
{
    public partial class Beni_animsa : System.Web.UI.Page
    {
        HttpCookie cerez = new HttpCookie("giris");
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Request.Cookies["giris"]!=null)
            {

                cerez = Request.Cookies["giris"];
                kuladi_txt.Text = cerez["kuladi"];
                hatirla_cek.Checked = true;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (kuladi_txt.Text.Equals("admin") && sifre_txt.Text.Equals("12345"))
            {
                
                Response.Write("Giriş başarılı");
                if (hatirla_cek.Checked)
                {
                 
                    cerez["kuladi"] = kuladi_txt.Text;
                    cerez.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cerez);
                }//cek ifi

            }//if
            else Response.Write("kullanıcı adı veya şifreniz yanlış");
        }
    }
}