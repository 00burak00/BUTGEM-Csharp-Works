using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public partial class sepet : System.Web.UI.Page
    {
        ArrayList musteri_sepet = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)    
                satin_al_btn.Attributes.Add("onclick", "return confirm('Siparişi onaylıyormusunuz')");
            {
           
                int urun_id = Convert.ToInt32(Request.QueryString["urunid"]);
                Urun eklenecek_urun = new Urundao().tek_urun_getir(urun_id);

                if (Session["sepet"] != null)
                {
                    musteri_sepet = (ArrayList)Session["sepet"];
                }
                int i = 0;
                bool kontrol = false;
                foreach (Sepetlik sepetteki_urun in musteri_sepet)
                {
                    if (sepetteki_urun.Urunum.Urunid == urun_id)
                    {
                        ((Sepetlik)musteri_sepet[i]).Adet += 1;
                        kontrol = true;
                        break;
                    }
                    i++;
                }
                if (kontrol == false)
                {
                    Sepetlik yeni_eklenecek = new Sepetlik()
                    {
                        Urunum = eklenecek_urun,
                        Adet = 1
                    };
                    musteri_sepet.Add(yeni_eklenecek);
                }

                Session["sepet"] = musteri_sepet;
                tablo_yaz();
            }
        }


        void tablo_yaz()
        {
           Double toplam = 0;

            foreach (Sepetlik sepetteki_urun in musteri_sepet)
            {
                TableRow satir = new TableRow();

                for (int i=0;i<5;i++)
                {
                    TableCell hucre = new TableCell()
                    {
                        BorderStyle = BorderStyle.Solid,
                        BorderWidth = 1
                    };
                    satir.Cells.Add(hucre);
                }
                Image urun_resmi = new Image()
                {
                    Height = 50,
                    Width = 50,
                    ImageUrl = "urun_resimleri/" + sepetteki_urun.Urunum.Resim
                };
                satir.Cells[0].Controls.Add(urun_resmi);
                satir.Cells[1].Text = sepetteki_urun.Urunum.Urunadi;
                satir.Cells[2].Text = sepetteki_urun.Urunum.Fiyat.ToString();
                TextBox adet_kutusu = new TextBox()
                {
                    ID ="adet"+sepetteki_urun.Urunum.Urunid,
                    Width =20,
                    Text=sepetteki_urun.Adet.ToString()
                };
                satir.Cells[3].Controls.Add(adet_kutusu);
                CheckBox sil_cek = new CheckBox()
                {
                    ID="sil_cek"+sepetteki_urun.Urunum.Urunid 
                };
                satir.Cells[4].Controls.Add(sil_cek);
                Table1.Rows.Add(satir);
                toplam += sepetteki_urun.Urunum.Fiyat * sepetteki_urun.Adet;
            }//for each
            Toplam_fiy_lbl.Text = "Sepetimizin toplamı=" + toplam;
        }

        protected void yenile_btn_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["sepet"]!=null)
            {
                musteri_sepet = (ArrayList)Session["sepet"];
            }
            int i = 0;
            ArrayList silinecek_urunler_idleri = new ArrayList();
            foreach (Sepetlik sepetteki_urun  in musteri_sepet)
            {

                int yeni_adet = 0;
                if (Request["adet" + sepetteki_urun.Urunum.Urunid] != "")
                    yeni_adet = Convert.ToInt32(Request["adet" + sepetteki_urun.Urunum.Urunid]);
                ((Sepetlik)musteri_sepet[i]).Adet = yeni_adet;

              String silinme_durumu=  Request.Form["sil_cek" + sepetteki_urun.Urunum.Urunid];

                if (silinme_durumu=="on" || yeni_adet==0)
                {

                    silinecek_urunler_idleri.Add(sepetteki_urun.Urunum.Urunid);
                }
                i++;
            }//for iç

         
            foreach (int silinecek_id in silinecek_urunler_idleri )
            {

                foreach (Sepetlik sepetteki_urun in musteri_sepet)
                {
                    if (silinecek_id == sepetteki_urun.Urunum.Urunid)
                    {
                        musteri_sepet.Remove(sepetteki_urun);
                        break;
                    }
                }

            }

            Session["sepet"] = musteri_sepet;
            tablo_yaz();

        }

        protected void satin_al_btn_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["sepet"] != null)
            {
                int sipno = new Siparis_dao().
              siparis_kaydet(((Uye)Session["uyem"]).Uyeid, (ArrayList)Session["sepet"]);
                siparis_lbl.Text = "Sipariş alındı no=" + sipno;
            }
        }
    }
}