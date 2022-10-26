using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class if_vize_final : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vizenot = Convert.ToInt32(vizetxt.Text);

            double ort = 0;
            if (butuntxt.Text != "")//bütünleme girilmişse
            {
                int butunnot = Convert.ToInt32(butuntxt.Text);
                ort = vizenot * 0.4 + butunnot * 0.6;
            }
            else//bütünleme yok
            {
                int finalnot = Convert.ToInt32(finaltxt.Text);
                ort = vizenot * 0.4 + finalnot * 0.6;
            }

            if (ort >= 50)
            {
                sonuclbl.Text = ort + " ile geçtiniz";
            }//if
            else//kalmış
            {
                if (butuntxt.Text != "")///butle kalmış
                {
                    sonuclbl.Text = ort + " ile kaldınız.bütünlemeden de kaldınız";
                    Button1.Enabled = false;
                }
                else //fin kalmış
                {
                    sonuclbl.Text = ort + " ile kaldınız.bütünleme notunu giriniz";
                    finallbl.Visible = false;
                    finaltxt.Visible = false;
                    butunlbl.Visible = true;
                    butuntxt.Visible = true;
                }
            }//else
        }
    }
}