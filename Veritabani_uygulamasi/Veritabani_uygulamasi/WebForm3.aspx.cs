using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace Veritabani_uygulamasi
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString ="Server=Localhost;Database=okul;Uid=root;Pwd=15043";
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select * from dersler", baglanti);
            MySqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                DropDownList1.Items.Add(oku["dersadi"].ToString());
            }
        }
    }
}