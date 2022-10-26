using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Veritabani_uygulamasi
{
    public class Connection_yapici
    {
        public SqlConnection baglantiya_gec()
        {
            SqlConnection bag = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Eticaret_vt.mdf;Integrated Security=True");
            return bag;
        }
    }
}