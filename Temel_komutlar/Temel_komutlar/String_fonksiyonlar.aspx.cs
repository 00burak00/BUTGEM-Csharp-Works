using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class String_fonksiyonlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String degisken = "Butgem Yazılım Umzanlığı";
            /*int sayi= degisken.Length;
            Response.Write(sayi);*/
            /* String yenideger= degisken.Replace("a", "i");
              Response.Write(yenideger);*/
            /*String yeni=degisken.Substring(3,4);
            Response.Write(yeni);*/
            /* int indexi=degisken.IndexOf("a");
             Response.Write(indexi);*/
            // Response.Write(degisken.ToUpper());
            /*String ad = "        kamil";
            TextBox1.Text = ad.Trim();*/
            /* String iller = "bursa:ankara:istanbul:izmir";
             String[] il_dizisi=iller.Split(':');
             foreach(String x in il_dizisi)
             {
                 ListBox1.Items.Add(x);
             }*/
            //String yeni=degisken.Remove(5, 6);
           // Response.Write(yeni);
            String ifade = "Butgeme hoşgeldiniz \n nasıl gidiyor \n yazılım uzmanlığı eğitimi";
            TextBox1.Text = ifade;
            
            
        }
    }
}