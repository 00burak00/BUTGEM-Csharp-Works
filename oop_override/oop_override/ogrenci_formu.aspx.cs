using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oop_override
{
    public partial class ogrenci_formu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ogno = 5;
            ogr1.Ad_soyad = "ismail gülaç";
            ogr1.Adres = "bursa";
            //Response.Write(ogr1);

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Ogno = 5;
            ogr2.Ad_soyad = "kamil ";
            ogr2.Adres = "ankra";

            if (ogr1.Equals(ogr2)==true) Response.Write("aynı öğrenci");
            else Response.Write("farklı öğrenci");
        }
    }
}