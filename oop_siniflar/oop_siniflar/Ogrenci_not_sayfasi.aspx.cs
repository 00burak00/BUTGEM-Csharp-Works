using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace oop_siniflar
{
    public partial class Ogrenci_not_sayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci_nesnesi = new Ogrenci();
            ogrenci_nesnesi.ogno = Convert.ToInt32(Interaction.InputBox("no girin", "", "", -1, -1));
            ogrenci_nesnesi.ad_soyad = Interaction.InputBox("ad soyad girin", "", "", -1, -1);
            ogrenci_nesnesi.adres = Interaction.InputBox("adres girin", "", "", -1, -1);
            string dersadi = Interaction.InputBox("ders adı girin", "", "", -1, -1);

            int[] notlar = new int[10];

            for (int i=0;i<notlar.Length;i++)
            {
                notlar[i] = Convert.ToInt32(Interaction.InputBox("not girin", "", "", -1, -1));
                int cevap = Convert.ToInt32(Interaction.InputBox("devam edecekmisin 1-evet 2-hayır", "", "", -1, -1));
            if (cevap == 2) break;
             }

           Response.Write( ogrenci_nesnesi.not_hesapla(dersadi, notlar));


        }
    }
}