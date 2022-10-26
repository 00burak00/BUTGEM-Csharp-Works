using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Veritabani_uygulamasi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Eticaret_vt.mdf;Integrated Security=True";
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from sehirler order by sehiradi asc";
            SqlDataReader oku= komut.ExecuteReader();
            int sayac = 1;
            while (oku.Read()==true)
            {
                DropDownList1.Items.Add(oku["sehiradi"].ToString());
                DropDownList1.Items[sayac].Value = oku["plaka"].ToString();
                sayac++;
            }


            baglanti.Close();
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["giris"] = "ok";
            Response.Redirect("uye_kayit.aspx");
        }
    }
}