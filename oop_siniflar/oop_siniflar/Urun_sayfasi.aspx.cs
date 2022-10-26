using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace oop_siniflar
{
    public partial class Urun_sayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(Interaction.InputBox("Kaç adet ürün girilecek", "","", -1, -1));
            Urun[] urun_listem = new Urun[adet];
            for(int i=0;i<adet;i++)
            {
                Urun yeni_urun = new Urun();
                yeni_urun.barkodno = Convert.ToInt32(Interaction.InputBox("Barkod gir", "", "", -1, -1));
                yeni_urun.urun_adi = Interaction.InputBox("Ürün adı gir", "", "", -1, -1);
                yeni_urun .kateadi = Interaction.InputBox("kategori gir", "", "", -1, -1);
                yeni_urun.fiyat = Convert.ToDouble(Interaction.InputBox("fiyat gir", "", "", -1, -1));
                urun_listem[i] = yeni_urun;
               byte cvp= Convert.ToByte(Interaction.MsgBox("Devam edecekmisiniz?", MsgBoxStyle.YesNo));
                if (cvp == 7) break;
            }//for
            byte secim = Convert.ToByte(Interaction.InputBox("1-Barkoda göre arama 2-min fiyata göre listele", "", "", -1, -1));

            if (secim == 1)
            {
                int aranan_barkod = Convert.ToInt32(Interaction.InputBox("aranan ürün Barkod gir", "", "", -1, -1));
                bool urun_kontrol = false;

                foreach (Urun gelenurun in urun_listem)
                {
                    if (gelenurun != null)//gelen urun nesnesi varsa
                    {
                        if (gelenurun.barkodno == aranan_barkod)
                        {
                            ListBox1.Items.Add(gelenurun.urun_bilgisi());
                            urun_kontrol = true;
                            break;
                        }

                    }
                }//for each
                if (urun_kontrol == false) Interaction.MsgBox("aradığınız ürün yok");


            }//secim 1
            else if (secim == 2)
            {
                double min_fiyat = Convert.ToDouble(Interaction.InputBox("min fiyat gir", "", "", -1, -1));
                foreach (Urun gelenurun in urun_listem)
                {
                    if (gelenurun != null)
                        if (gelenurun.fiyat >= min_fiyat) ListBox1.Items.Add(gelenurun.urun_bilgisi());
                }
            }//secim 2
            else Interaction.MsgBox("Ya nlış Seçim");
        
        
        }
    }
}