using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Session_sepet_uygulamasi
{
    public partial class urundetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kuladi"] == null)
            {
                Response.Write("bu sayfayı sadece giriş yapanlar görebilir");
                Response.End();
            }
            else
            {
                Response.Write("Hoşgeldiniz " + Session["kuladi"]);
                int kateno = Convert.ToInt32(Session["kateno"]);

                switch (kateno)
                {
                    case 1:
                        Image1.ImageUrl = "img/ana1.jpg";
                        ad_lbl1.Text = "Msi";
                        fiy_lbl1.Text = "450";
                        Image2.ImageUrl = "img/ana2.jpg";
                        ad_lbl2.Text = "gigabyte";
                        fiy_lbl2.Text = "600";
                        break;
                    case 2:
                        Image1.ImageUrl = "img/ram1.jpg";
                        ad_lbl1.Text = "oem";
                        fiy_lbl1.Text = "150";
                        Image2.ImageUrl = "img/ram2.jpg";
                        ad_lbl2.Text = "kingston";
                        fiy_lbl2.Text = "225";
                        break;
                    case 3:
                        Image1.ImageUrl = "img/hdd1.jpg";
                        ad_lbl1.Text = "samsung ssd";
                        fiy_lbl1.Text = "550";
                        Image2.ImageUrl = "img/hdd2.jpg";
                        ad_lbl2.Text = "western dijital";
                        fiy_lbl2.Text = "625";
                        break;
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Urun yeni_urun = new Urun(ad_lbl1.Text, Convert.ToInt32(fiy_lbl1.Text), Image1.ImageUrl, 1);
            sepete_ekle(yeni_urun);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Urun yeni_urun = new Urun(ad_lbl2.Text, Convert.ToInt32(fiy_lbl2.Text), Image2.ImageUrl, 1);
            sepete_ekle(yeni_urun);
        }

        void sepete_ekle(Urun yeni_urun)
        {
            ArrayList musteri_sepet = new ArrayList();
            if (Session["sepet"] != null)//önceden sepet oluşturulmuş ve içinde ürün varsa
            {
                musteri_sepet = (ArrayList)Session["sepet"];
                int i = 0;//sepette bulduğumuz ürün yeri için
                bool kontrol = false;
                 foreach (Urun sepetteki_urun in musteri_sepet)//daha önceden ürün varmı
                {
                    if (sepetteki_urun.Urun_adi.Equals(yeni_urun.Urun_adi))
                    {
                        ((Urun)musteri_sepet[i]).Adet += 1;
                        kontrol = true;//bulduk
                        break;
                    }
                    i++;
                }
                if (kontrol == false)//yeni ürün sepete ekle gitsin
                    musteri_sepet.Add(yeni_urun);
            }
            else//daha hiç ürün yok ilk ürün 
                musteri_sepet.Add(yeni_urun);
            Session["sepet"] = musteri_sepet;
            Response.Redirect("sepet.aspx");
        }
    }
}