using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nesneler
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox teks_kutusu = new TextBox();
            teks_kutusu.ID = "adi";
            teks_kutusu.ForeColor = System.Drawing.Color.Red;
            teks_kutusu.Text = "ali";
            PlaceHolder1.Controls.Add(teks_kutusu);
            HyperLink linkim = new HyperLink()
            {
                Text = "sil",
                NavigateUrl ="sil.aspx?uyeid=1",
            };
            Page.Controls.Add(linkim);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(Request.Form["adi"]);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int kac_adet = Convert.ToInt32(TextBox1.Text);
            for (int i=1;i<=kac_adet;i++)
            {
                TableRow satir = new TableRow();
                for (int j=1;j<=2;j++)
                {
                    TableCell hucre = new TableCell()
                    {
                        BorderStyle = BorderStyle.Solid,
                        BorderColor=System.Drawing.Color.Red,
                        BorderWidth =1
                        
                    };
                    if (j == 1)
                    {
                        TextBox ad_kutusu = new TextBox();
                        ad_kutusu.ID = "ad" + i;
                        hucre.Controls.Add(ad_kutusu);
                    }
                    else
                    {
                        TextBox dog_kutusu = new TextBox();
                        dog_kutusu.ID = "dogum" + i;
                        hucre.Controls.Add(dog_kutusu);
                    }
                    satir.Cells.Add(hucre);
                }//hucre foru

                Table1.Rows.Add(satir);
            }//satir foru
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            for (int i=1;i<=Convert.ToInt32(TextBox1.Text);i++)
            {
                string sonuc = Request.Form["ad" + i] + Request.Form["dogum" + i] + "<br>";
                Response.Write(sonuc);
            }
        }
    }
}