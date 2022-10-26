using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Temel_komutlar
{
    public partial class Buyuk_kucuk_not : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte mevcud = Convert.ToByte(Interaction.InputBox("mevcud girin", "", "", -1, -1));
            string[] isimler = new string[mevcud];
            int[] notlar = new int[mevcud];
            for (int i=0;i<mevcud;i++)
            {
                isimler[i] = Interaction.InputBox("isim gir", "", "", -1, -1);
                notlar[i]=Convert.ToInt32 (Interaction.InputBox("not gir", "", "", -1, -1));      
            }
            for (int j=0;j<mevcud;j++) ListBox1.Items.Add(isimler[j] + "--->" + notlar[j]);

            int enb_not = notlar[0], enk_not = notlar[0];
            int enk_index = 0, enb_index = 0;

            for (int k=1;k<mevcud;k++)
            {
                if (enb_not < notlar[k])
                {
                    enb_not = notlar[k];
                    enb_index = k;
                }

                if (enk_not>notlar[k])
                {
                    enk_not = notlar[k];
                    enk_index = k;
                }
            }//for karşılaştırma

            Response.Write("En büyük not=" + enb_not + "ile" + isimler[enb_index] + "isimli kişiye ait<br>");
            Response.Write("En küçük not=" + enk_not + "ile" + isimler[enk_index] + "isimli kişiye ait<br>");

        }
    }
}