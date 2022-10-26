using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
namespace Veritabani_uygulamasi
{
    public class Meslek_dao
    {
        public ArrayList tum_meslekleri_getir()
        {
            ArrayList meslek_listesi = new ArrayList();
            SqlConnection bag = new Connection_yapici().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from meslek order by meslekad", bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Meslek  yeni_meslek = new  Meslek(Convert.ToByte(oku["meslekid"]), oku["meslekad"].ToString());
                meslek_listesi.Add(yeni_meslek);
            }

            oku.Close();
            bag.Close();
            return meslek_listesi;

        }
    }
}