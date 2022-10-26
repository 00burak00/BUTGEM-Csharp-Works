using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veritabani_uygulamasi
{
    public partial class Kategori_islemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayi = new Kategoriler_dao().kategori_ekle(kateadi_txt.Text);
            if (sayi > 0) Response.Write("kayıt başarılı");
            else if (sayi == -1) Response.Write("bu kategori kayıtlı");
            else Response.Write("bilinmeyen hata");
           
        }
    }
}