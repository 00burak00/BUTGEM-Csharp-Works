using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
namespace Temel_komutlar
{
    public partial class if4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sonuc_lbl.BackColor = Color.Yellow;
            sonuc_lbl.ForeColor = Color.Red;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            double sayi1 = Convert.ToDouble(sayi1_txt.Text);
            double sayi2 = Convert.ToDouble(sayi2_txt.Text);
            if (topla_radio.Checked == true)
            {
                sonuc = sayi1 + sayi2;
                sonuc_lbl.Text = "Toplama sonucu=" + sonuc;
            }//top
            else if (cikar_radio.Checked == true)
            {
                sonuc = sayi1 - sayi2;
                sonuc_lbl.Text = "Çıkarma sonucu=" + sonuc;
            }//fark
            else if (carp_radio.Checked == true)
            {
                sonuc = sayi1 * sayi2;
                sonuc_lbl.Text = "çarpma sonucu=" + sonuc;
            }//carp
            else if (bol_radio.Checked == true)
            {
                sonuc = sayi1 / sayi2;
                sonuc_lbl.Text = "Bölme sonucu=" + sonuc;
            }//bol
            else sonuc_lbl.Text = "işlem seçmediniz";
        }//klik
    }
}