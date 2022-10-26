using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace Temel_komutlar
{
    public partial class Dizi_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte[] notlar = new byte[5];
            for (int i = 0; i < notlar.Length; i++)
            {
              notlar[i]=Convert.ToByte(Interaction.InputBox("Not giriniz", "Giriş", "", -1, -1));
                
            }
            int top=0;
            foreach (byte notdegeri in notlar)
            {
                top += notdegeri;
                Response.Write(notdegeri + "<br>");
            }
            int ort = top / notlar.Length;
            if (ort >= 50) Response.Write(ort +"geçtiniz");
            else Response.Write(ort + "kaldınız");


            }
    }
}