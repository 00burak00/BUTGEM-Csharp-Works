using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temel_komutlar
{
    public partial class for1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            for (int sayac=1;sayac <=100;sayac ++)
            {
                ///if (sayac == 15) break;
                if (sayac == 15) continue;//başa dön
                Response.Write(sayac + "-->Yazılım Uzmanlığı<br>");
               
            }//for
             //dfsfj
             
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int top = 0;
            for (int i=0;i<=100;i+=2)
            {
                top = top + i;//top+=i
                
            }
            Response.Write("toplam=" + top);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            int top = 0;
            for (int j=99;j>0;j-=2)
            {
                top += j;
                Response.Write("toplam=" + top + "<br>");
            }

        }
    }
}