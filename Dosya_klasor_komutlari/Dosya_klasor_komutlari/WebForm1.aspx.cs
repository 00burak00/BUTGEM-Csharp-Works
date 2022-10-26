using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Dosya_klasor_komutlari
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           String yol= Server.MapPath("");//bu sayfa serverda nerde yolunu bana getir;
                                          //Response.Write(yol);


            //Directory.Delete(yol + "/deneme");
            /* if (Directory.Exists(yol + "/deneme") == true)
                 Response.Write("klasör var");
             else
                 Directory.CreateDirectory(yol + "/deneme");*/
            /*  string[] dizinler=Directory.GetDirectories(yol);
              foreach (var x in dizinler)
              {
                  ListBox1.Items.Add(x.Substring(yol.Length+1));
              }*/
            yol +=  "/img";
            string[] dosyalar = Directory.GetFiles(yol);
            foreach (var x in dosyalar)
            {
                ListBox1.Items.Add(x.Substring(yol.Length + 1));
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*String yol = Server.MapPath("");
            Directory.Delete(yol + "/" + ListBox1.SelectedValue);
            ListBox1.Items.Clear();
            string[] dizinler = Directory.GetDirectories(yol);
            foreach (var x in dizinler)
            {
                ListBox1.Items.Add(x.Substring(yol.Length + 1));
            }*/
            Image1.ImageUrl = "img/" + ListBox1.SelectedValue;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String yol = Server.MapPath("");
            //yol += "/img";
            //File.Delete(yol + "/indir.jpg");
            //File.Copy(yol + "/img/ana1.jpg", yol + "/css/ana1.jpg");
            
        }
    }
}