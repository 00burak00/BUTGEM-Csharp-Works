using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace kirtasiye_otomasyon_kalitim
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int urun_sayisi = Convert.ToInt32(Interaction.InputBox("Ürün sayısı", "", "", -1, -1));
            Kirtasiye[] urun_listem = new Kirtasiye[urun_sayisi];
            for (int i=0;i<urun_sayisi;i++)
            {
                long girilen_barkod = Convert.ToInt64(Interaction.InputBox("barkod girin", "", "", -1, -1));
                bool varmi = false;
                foreach (Kirtasiye gelen_urun in urun_listem)
                {
                    if (gelen_urun!=null)
                    if (gelen_urun.Barkod_no == girilen_barkod) varmi = true;//ürün daha önceden kayıtlı
                }
                if (varmi ==true)
                {
                    i--;
                    continue;
                }

                byte secim = Convert.ToByte(Interaction.InputBox("1-Kitap 2-sarf mlz", "", "", -1, -1));
                switch (secim)
                {
                    case 1:
                        Kitap kit = new Kitap()
                        {
                            Barkod_no = girilen_barkod,
                            Adi = Interaction.InputBox("adi", "", "", -1, -1),
                            Fiyat = Convert.ToInt32(Interaction.InputBox("fiyat", "", "", -1, -1)),
                            Yazaradi = Interaction.InputBox("yazar adi", "", "", -1, -1),
                            Sayfa_sayisi = Convert.ToInt32(Interaction.InputBox("sayfa sayısı", "", "", -1, -1)),
                            Resim = Interaction.InputBox("resim adı", "", "", -1, -1),
                            Tedarikci = tedarikcigir(),
                        };
                        urun_listem[i] = kit;
                        break;

                    case 2:
                        Sarf_malzeme srf_mlz = new Sarf_malzeme()
                        {
                            Barkod_no = girilen_barkod,
                            Adi = Interaction.InputBox("adi", "", "", -1, -1),
                            Fiyat = Convert.ToInt32(Interaction.InputBox("fiyat", "", "", -1, -1)),
                            Tur = Interaction.InputBox("Türü", "", "", -1, -1),
             
                            Resim = Interaction.InputBox("resim adı", "", "", -1, -1),
                            Tedarikci = tedarikcigir(),
                        };
                        urun_listem[i] = srf_mlz;
                        break;
                }

            }//giriş for
                    byte islem_sec= Convert.ToByte(Interaction.InputBox("1-satın al 2-tümü listele", "", "", -1, -1));
                    switch (islem_sec)
            {
                case 1:
                    long satin_alinacak_barkod = Convert.ToInt64(Interaction.InputBox("satın alınacak ürün barkod girin", "", "", -1, -1));
                    
                    foreach (Kirtasiye gelen_urun in urun_listem)
                    {
                        if (gelen_urun.Barkod_no == satin_alinacak_barkod)
                        {
                            int adet = Convert.ToInt32(Interaction.InputBox("adet girin", "", "", -1, -1));
                           int top_fiyat= gelen_urun.satin_al(adet);
                            Response.Write("Satın almak istediğiniz ürün" + gelen_urun.urun_bilgisi()
                                + "Ödenecek toplam tutar=" + top_fiyat);
                        }
                    }
                    break;
                case 2:
                    Response.Write("<table border=1>");
                    Response.Write("<tr><td>Ürün adı</td><td>barkod no</td><td>fiyat</td><td>resim</td></tr>");
                    foreach (Kirtasiye gelen_urun in urun_listem)
                    {
                        Response.Write("<tr><td>"+ gelen_urun.Adi
                            + "</td><td>" + gelen_urun.Barkod_no +
                            "</td><td>"+ gelen_urun.Fiyat +"</td><td><img src=img/"+
                            gelen_urun.Resim +"></td></tr>");
                    }

                    Response.Write("</table>");
                    break;

            }
        
        
        
        
        
        }//click

        private Tedarikci tedarikcigir()
        {
            Tedarikci ted = new Tedarikci()
            {
                Ted_adi = Interaction.InputBox("Tedarikçi adı", "", "", -1, -1),
                Ted_tel = Interaction.InputBox("Ted tel", "", "", -1, -1),
            };
            return ted;
        }
    }
}