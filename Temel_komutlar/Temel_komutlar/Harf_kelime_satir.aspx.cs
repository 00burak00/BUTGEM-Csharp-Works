using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class Harf_kelime_satir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ifade = "Butgeme hoşgeldiniz \n nasıl gidiyor \n yazılım uzmanlığı eğitimi";
            int kelimesayisi=1, satirsayisi=1, harfsayisi = ifade.Length;
            for (int i=0;i<ifade.Length;i++)
            {
                String alinan = ifade.Substring(i, 1);
                switch (alinan)
                {
                    case " ":
                        kelimesayisi++;
                        harfsayisi--;
                        break;
                    case "\n":
                        satirsayisi++;
                        harfsayisi--;
                        kelimesayisi--;
                        break;
                }//switch
            }//for
            Response.Write("harf sayısı=" + harfsayisi + "kelime=" + kelimesayisi + "satir=" + satirsayisi);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String ifade = "Butgeme hoşgeldiniz \n nasıl gidiyor \n yazılım uzmanlığı eğitimi";
            TextBox1.Text = ifade;
        }
    }
}