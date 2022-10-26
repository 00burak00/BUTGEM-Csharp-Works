using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Arraylist_vt_ornek
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Urunislemleri urun_isi_nesnesi = new Urunislemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            liste_yaz();
        }
        void liste_yaz()
        {
            ListBox1.Items.Clear();
            ArrayList urunlerim = urun_isi_nesnesi.urunlerigetir();
            foreach (Urun gelen_urun in urunlerim)
            {
                ListBox1.Items.Add(gelen_urun.ToString());
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Urun yeni_urun = new Urun(urun_adi_txt.Text, 
            Convert.ToInt32(urun_fiyat_txt.Text), Convert.ToInt32(urun_no_txt.Text));
            urun_isi_nesnesi.Urun_kaydet(yeni_urun);
            liste_yaz();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           bool kontrol= urun_isi_nesnesi.Urun_sil(Convert.ToInt32(urun_no_txt.Text));
            if (kontrol)
            { Response.Write("Urun silindi"); liste_yaz(); }
            else Response.Write("Silinmedi.Ürün yok");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           Urun aranan_urun= urun_isi_nesnesi.urunbul(Convert.ToInt32(urun_no_txt.Text));
            if (aranan_urun == null) Response.Write("Ürün yok");
            else
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add(aranan_urun.ToString());
            }
        }
    }
}