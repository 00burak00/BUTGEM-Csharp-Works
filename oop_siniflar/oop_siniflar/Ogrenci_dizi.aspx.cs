using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace oop_siniflar
{
    public partial class Ogrenci_dizi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.ogno = 1;
            ogr1.ad_soyad = "ismail abi";
            ogr1.adres = "Bursa";
            Ogrenci ogr2 = new Ogrenci();
            ogr2.ogno = 2;
            ogr2.ad_soyad = "kamil abi";
            ogr2.adres = "Ankara";
            Ogrenci ogr3 = new Ogrenci();
            ogr3.ogno = 13;
            ogr3.ad_soyad = "ayşe x";
            ogr3.adres = "Bursa";

            Ogrenci[] ogrenciler = new Ogrenci[3];

            ogrenciler[1] = ogr3;
            ogrenciler[0] = ogr1;
            ogrenciler[2] = ogr2;

            foreach( Ogrenci gelenogr   in ogrenciler )
            {
                ListBox1.Items.Add(gelenogr.ogrenci_bilgisi());

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            byte mevcud = Convert.ToByte( Interaction.InputBox("Sınıf kaç kişi", "", "", -1, -1));
            Ogrenci[] ogrenci_listesi = new Ogrenci[mevcud];

            for (int i=0;i<mevcud;i++)
            {
                Ogrenci yeniogr = new Ogrenci();
                yeniogr.ogno = Convert.ToInt32(Interaction.InputBox("No girin", "", "", -1, -1));
                yeniogr.ad_soyad = Interaction.InputBox("ad soyad girin", "", "", -1, -1);
                yeniogr.adres = Interaction.InputBox("adres girin", "", "", -1, -1);
                ogrenci_listesi[i] = yeniogr;
            }

            foreach (Ogrenci gelen in ogrenci_listesi)
            {
                ListBox1.Items.Add(gelen.ogrenci_bilgisi());
            }

        }
    }
}