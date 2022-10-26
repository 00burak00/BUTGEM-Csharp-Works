using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class Kredi_hesaplama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tip_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            vade_listesi.Items.Clear();
            byte tip = Convert.ToByte(tip_listesi.SelectedValue);
            byte vade = 0;
            switch (tip)
            {
                case 1:
                    vade = 36;
                    break;
                case 2:
                    vade = 60;
                    break;
                case 3:
                    vade = 120;
                    break;
            }//switch
            for (int i = 1; i <= vade; i++)
            {
                vade_listesi.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double aylik_taksit, toplam_miktar, carpan, oran, faiz_orani=0,vade;
            vade = Convert.ToDouble(vade_listesi.SelectedValue);
            switch (Convert.ToByte(tip_listesi.SelectedValue))
            {
                case 1:faiz_orani = 2.04;break;
                case 2:faiz_orani = 1.83; break;
                case 3:faiz_orani = 1.96; break;
            }//swict
            oran = (vade + 1) / 2*faiz_orani;
            carpan = oran / 100 + 1;
            aylik_taksit = Convert.ToInt32(miktar_txt.Text) * carpan / vade;
            toplam_miktar = aylik_taksit * vade;
            aylik_lbl.Text = "Aylık Taksit="+aylik_taksit.ToString();
            toplam_lbl.Text = "toplam="+toplam_miktar.ToString();
            faiz_lbl.Text ="faiz oranı="+ faiz_orani.ToString();

            DateTime tarih = DateTime.Now;
            Response.Write("<table border=1><tr><td>Ödeme Tarihi</td><td>Aylik taksit</td><td>Kalan miktar</td></tr>");

            for (int i=1;i<=vade;i++)
            {
                Response.Write("<tr><td>" + tarih.AddMonths(i).ToShortDateString() + "</td><td>" +
                    aylik_taksit + "</td><td>" + (toplam_miktar - aylik_taksit * i) + "</td></tr>");
            }

            Response.Write("</table>");

        }
    }
}