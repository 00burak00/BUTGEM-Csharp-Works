using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
namespace text_dosya_islemleri
{
    public partial class Urun_islemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string yol = Server.MapPath("");
                yol += "/dosya/kategori.txt";
                StreamReader dosya = File.OpenText(yol);
                String s;
                int i = 1;//drop down listeki eleman yeri 
                while ((s = dosya.ReadLine()) != null)
                {
                    string[] s2 = s.Split(':');
                    kate_listesi.Items.Add(s2[0]);
                    kate_listesi.Items[i].Value = s2[1];
                    i++;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            urun yeni_urun = new urun()
            {
                Barkod = Convert.ToInt32(barkod_txt.Text),
                Urun_adi = urun_aditxt.Text,
                Fiyat = Convert.ToInt32(fiyat_txt.Text),
                Kateno = Convert.ToInt32(kate_listesi.SelectedValue)
            };
            new Urun_dao().urun_kaydet(yeni_urun);
        }
        

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            foreach (urun gelen_urun in new Urun_dao().urunleri_getir())
            {
                ListBox1.Items.Add(gelen_urun.ToString());
            }
        }

       
    }
}