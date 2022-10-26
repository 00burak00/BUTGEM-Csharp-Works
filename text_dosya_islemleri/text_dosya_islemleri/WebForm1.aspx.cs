using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace text_dosya_islemleri
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string yol = Server.MapPath("");
            yol += "/dosya/veri.txt";
            if (File.Exists(yol)==false)
            {
                StreamWriter dosya = File.CreateText(yol);
                dosya.WriteLine("butgem");
                dosya.WriteLine("yazılım");
                dosya.WriteLine("tuncay");
                dosya.Flush();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string yol = Server.MapPath("");
            yol += "/dosya/veri.txt";
            StreamReader dosya = File.OpenText(yol);
            /* string s= dosya.ReadLine();
              Response.Write(s);*/
            string s="";
            while((s=dosya.ReadLine())!=null)
            {
                
                DropDownList1.Items.Add(s);
            }
        }
    }
}