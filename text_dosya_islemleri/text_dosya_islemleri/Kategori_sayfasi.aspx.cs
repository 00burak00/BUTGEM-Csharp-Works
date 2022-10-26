using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace text_dosya_islemleri
{
    public partial class Kategori_sayfasi : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string yol = Server.MapPath("");
            yol += "/dosya/kategori.txt";
            StreamWriter dosya;
            if (File.Exists(yol) == false)
            {
                dosya=File.CreateText(yol);
                dosya.WriteLine(kate_txt.Text+":1");
                dosya.Flush();
            }
            else//varsa dosya
            {
                int son_kateno = Convert.ToInt32(kate_no_hesapla());
                dosya = File.AppendText(yol);
                dosya.WriteLine(kate_txt.Text+":"+(son_kateno+1) );
                dosya.Flush();
            }
            dosya.Close();
        }


        string kate_no_hesapla()
        {
            string yol = Server.MapPath("");
            yol += "/dosya/kategori.txt";
            StreamReader dosya = File.OpenText(yol);
            string a = dosya.ReadToEnd();
            string[] a1 = a.Split(':');
            dosya.Close();
           return a1[a1.Length - 1];
        }
  
    }
}