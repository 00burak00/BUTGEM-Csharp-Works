using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_siniflar
{
    public partial class Dortislem_sayfasi : System.Web.UI.Page
    {
        Dortislem_ dortislem_nesnesi = new Dortislem_();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void topla_radio_CheckedChanged(object sender, EventArgs e)
        {
            dortislem_nesnesi.secim = 1;
            isyap();
        }

        protected void cikar_radio_CheckedChanged(object sender, EventArgs e)
        {
            dortislem_nesnesi.secim = 2;
            isyap();
        }

        void isyap()
        {
            //Dortislem_ dortislem_nesnesi = new Dortislem_(); local
            dortislem_nesnesi.sayi1 = Convert.ToInt32(sayi1_txt.Text);
            dortislem_nesnesi.sayi2 = Convert.ToInt32(sayi2_txt.Text);
            Response.Write("işlem sonucu=" + dortislem_nesnesi.islemyap());
        }

        protected void carp_radio_CheckedChanged(object sender, EventArgs e)
        {
            dortislem_nesnesi.secim = 3;
            isyap();
        }

        protected void bol_radio_CheckedChanged(object sender, EventArgs e)
        {
            dortislem_nesnesi.secim = 4;
            isyap();
        }
    }//class
}