using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class switch_3_doviz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doviz_turu_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            double miktar = Convert.ToDouble(miktar_txt.Text);
            string tip = doviz_turu_listesi.SelectedItem.Text;
            double tl_karsiligi=0;
            switch (tip)
            {
                case "Dolar":
                    tl_karsiligi = 14.1 * miktar;
                    break;
                case "Euro":
                    tl_karsiligi = 15 * miktar;
                    break;
                case "Yen":
                    tl_karsiligi = 19 * miktar;
                    break;

            }//switch
            sonuc_lbl.Text = "Dövizinizin TL karşılığı=" + tl_karsiligi;
        }
    }
}