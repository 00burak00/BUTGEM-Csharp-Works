using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_compositıon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ogno = 12;
            ogr1.Adsoyad = "ahmet";
            Adres adr = new Adres();
            adr.Il = "bursa";
            adr.Ilce = "nilüfer";
            adr.Mahalle = "ihsaniye";
            ogr1.Ikamet_adresi = adr;
            Adres m_adres = new Adres();
            m_adres.Il = "Ankara";
            m_adres.Ilce = "ulus";
            m_adres.Mahalle = "xx";
            ogr1.Memleket_adresi = m_adres;
            Response.Write(ogr1.ogrencibilgisi());
        }
    }
}