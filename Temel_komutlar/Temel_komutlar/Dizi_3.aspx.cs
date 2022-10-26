using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Temel_komutlar
{
    public partial class Dizi_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte mevcud = Convert.ToByte(Interaction.InputBox("Sınıf mevcudu kaç", "", "", -1, -1));
            string[] isimler = new string[mevcud];
            for (int i=0;i<isimler.Length;i++)
            {
                isimler[i] = Interaction.InputBox("isim gir", "", "", -1, -1);
            }
           
            string aranan_isim = Interaction.InputBox("Aradığınız kişi ismi", "", "", -1, -1);
            int indexi=Array.IndexOf(isimler, aranan_isim);
            if (indexi != -1) Interaction.MsgBox("Aradığınız kişi var");
            else Interaction.MsgBox("aradığınız kişi yok");

            Array.Sort(isimler);
            foreach (string isim in isimler)
            {
                ListBox1.Items.Add(isim);

            }

        }
    }
}