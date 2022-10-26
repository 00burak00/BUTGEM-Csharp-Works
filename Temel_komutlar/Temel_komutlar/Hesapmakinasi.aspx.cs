using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class Hesapmakinasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toplabtn_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32 (sayi1txt.Text);
            int sayi2 = Convert.ToInt32(sayi2txt.Text);
            int top = sayi1 + sayi2;
            Response.Write("Sayıların toplamı=" + top);
        }

        protected void cikarbtn_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayi1txt.Text);
            int sayi2 = Convert.ToInt32(sayi2txt.Text);
          
            int fark = sayi1 - sayi2;
            Response.Write("Fark=" + fark);
        }
    }
}