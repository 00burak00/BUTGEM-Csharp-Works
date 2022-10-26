using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace Veritabani_uygulamasi
{
    public partial class mysql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection bag=new MySqlConnection ("Server=localhost;Database=okul;Uid=root;Pwd=15043");
            bag.Open();
            MySqlCommand cmd = new MySqlCommand("select * from ogrenciler", bag);
            MySqlDataReader oku= cmd.ExecuteReader();
            oku.Read();
            Response.Write(oku["adsoyad"]);
        }
    }
}