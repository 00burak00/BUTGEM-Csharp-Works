using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
namespace Veritabani_uygulamasi
{
    public class Kategoriler_dao
    {
        public int kategori_ekle(string kateadi)
        {
            int sayi = 0;
           try
            {
                SqlConnection bag = new Connection_yapici().baglantiya_gec();
                bag.Open();
                string sql = "insert into kategoriler (kateadi) values (@kateadi)";
                SqlCommand cmd = new SqlCommand(sql, bag);
                cmd.Parameters.AddWithValue("@kateadi", kateadi);
               
                sayi = cmd.ExecuteNonQuery();
                bag.Close();

           }
            catch (SqlException hata) { 
                sayi = -1; }
            catch (Exception) { sayi = -2; }
            return sayi;

        }

        public ArrayList tum_kategori_getir()
        {
            ArrayList kate_listesi = new ArrayList();
            SqlConnection bag = new Connection_yapici().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriler order by kateadi", bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Kategori yeni_kate = new Kategori(Convert.ToByte(oku["kateno"]), oku["kateadi"].ToString());
                kate_listesi.Add(yeni_kate);
            }

            oku.Close();
            bag.Close();
            return kate_listesi;

        }
    }
}