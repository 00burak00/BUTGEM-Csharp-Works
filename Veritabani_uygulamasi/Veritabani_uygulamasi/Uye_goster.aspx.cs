using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class Uye_goster : System.Web.UI.Page
    {
        ArrayList uye_listem;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ArrayList sehirler = new Sehirler_dao().tum_sehirleri_getir();
                int j = 0;
                foreach (Sehir gelen_sehir in sehirler)
                {
                    j++;
                    sehir_listesi.Items.Add(gelen_sehir.Sehiradi);
                    sehir_listesi.Items[j].Value = gelen_sehir.Plaka.ToString();
                }
                uye_listem = new Uyeler_dao().uyeler_all_list();
                tablo_yaz();
            }
        }

        protected void sehir_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
           uye_listem = new Uyeler_dao().uye_filtrele("", Convert.ToInt32(sehir_listesi.SelectedValue)) ;
            tablo_yaz();
        
        }

        protected void email_txt_TextChanged(object sender, EventArgs e)
        {
           uye_listem = new Uyeler_dao().uye_filtrele(email_txt.Text, Convert.ToInt32(sehir_listesi.SelectedValue));
            tablo_yaz();
        }

        public void tablo_yaz()
        {
            foreach (Uye gelen_uye in uye_listem)
            {
                TableRow satir = new TableRow();
                for (int i = 0; i < 9; i++)
                {
                    TableCell hucre = new TableCell();
                    hucre.BorderStyle = BorderStyle.Solid;
                    hucre.BorderWidth = 1;
                    satir.Cells.Add(hucre);
                }//for
                satir.Cells[0].Text = gelen_uye.Uyeid.ToString();
                satir.Cells[1].Text = gelen_uye.Adsoyad;
                satir.Cells[2].Text = gelen_uye.Kuladi;
                satir.Cells[3].Text = gelen_uye.Email;
                satir.Cells[4].Text = gelen_uye.Dogtar.ToShortDateString();
                satir.Cells[5].Text = gelen_uye.Sehir.Sehiradi;
                satir.Cells[6].Text = gelen_uye.Meslek.Meslekad;
                HyperLink sil_link = new HyperLink();
                sil_link.Text = "sil";
                sil_link.NavigateUrl = "uye_sil.aspx?uyeid=" + gelen_uye.Uyeid;
                satir.Cells[7].Controls.Add(sil_link);
                HyperLink deg_link = new HyperLink();
                deg_link.Text = "düzenle";
                deg_link.NavigateUrl = "uye_duzenle.aspx?uyeid=" + gelen_uye.Uyeid;
                satir.Cells[8].Controls.Add(deg_link);
                Table1.Rows.Add(satir);

            }//for iç
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            uye_listem = new Uyeler_dao().uyeler_all_list();
            tablo_yaz();
        }
    }
}