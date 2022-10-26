using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uyem"]==null)
            {
                Response.Write("Ürünleri Görebilmek için üye girişi yapın veya kayıt olun");
                Response.End();
            }

            int kateno = Convert.ToInt32(Request.QueryString["kateno"]);
            int sayfano = 0;
            if (Request.QueryString["sayfano"] == null) sayfano = 1;
            else sayfano = Convert.ToInt32(Request.QueryString["sayfano"]);
            int baslangıcyeri = (sayfano - 1) * 9;
            ArrayList urunler= new Urundao().sayfali_urun_getir(kateno, baslangıcyeri);
            int i = 0;//satırlarımı kontrol edecek
            int j = 0;//hücreleri kontrol edecek
            foreach (Urun gelenurun     in urunler)
            {
                Image resim = new Image();
                resim.Height = 90;
                resim.Width = 90;
                resim.ImageUrl = "urun_resimleri/" + gelenurun.Resim;
                Table1.Rows[i].Cells[j].Controls.Add(resim);
                Table1.Rows[i].Cells[j].Controls.Add(new LiteralControl("<br>Ürün adı" + gelenurun.Urunadi + "<br>Fiyatı=" + gelenurun.Fiyat+"<br>"));
                HyperLink sepet_linki = new HyperLink();
                sepet_linki.ImageUrl = "img/sepet.png";
                //sepet_linki.NavigateUrl = "sepet.aspx?urunid=" + gelenurun.Urunid;
                sepet_linki.Attributes.Add("onclick", "return GB_showCenter('Sepetiniz','../sepet.aspx?urunid="
                    + gelenurun.Urunid + "',500,800)");
                Table1.Rows[i].Cells[j].Controls.Add(sepet_linki);
                j++;
                if (j==3)
                {
                    j = 0;
                    i += 1;
                }
            }
            sayfala(kateno, sayfano);

        }

        public void sayfala(int kateno,int bulundugum_sayfa)
        {
            int toplam_sayfa_sayisi = 0, toplam_kayit_sayisi = 0;
            toplam_kayit_sayisi = new Urundao().toplam_urunsayisi(kateno);
            if (toplam_kayit_sayisi % 9 == 0) toplam_sayfa_sayisi = toplam_kayit_sayisi / 9;
            else toplam_sayfa_sayisi = toplam_kayit_sayisi / 9 + 1;
            string yazimiz = "Sayfalar ";
            if (bulundugum_sayfa >1)
            {
                yazimiz += "<a href=urunler.aspx?kateno=" + kateno + "&sayfano=" 
                    + (bulundugum_sayfa - 1) + ">Önceki</a>";       
            }

            for(int i=1;i<=toplam_sayfa_sayisi;i++)
            {
                yazimiz += "<a href=urunler.aspx?kateno=" + kateno + "&sayfano="
                   + i + " class='btn btn-danger'>" + i+ "</a>";
            }
            if (bulundugum_sayfa < toplam_sayfa_sayisi)
            {
                yazimiz += "<a href=urunler.aspx?kateno=" + kateno + "&sayfano="
                    + (bulundugum_sayfa + 1) + "  >sonraki</a>";
            }
            Label2.Text = yazimiz;
        }
    }
}