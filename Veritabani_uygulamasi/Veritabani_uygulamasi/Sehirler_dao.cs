using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
namespace Veritabani_uygulamasi
{
    public class Sehirler_dao
    {
        public ArrayList tum_sehirleri_getir()
        {
            ArrayList sehir_listesi = new ArrayList();
            SqlConnection bag = new Connection_yapici().baglantiya_gec();
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from sehirler order by sehiradi", bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read ())
            {
                Sehir yeni_sehir = new Sehir(Convert.ToByte(oku["plaka"]), oku["sehiradi"].ToString());
                sehir_listesi.Add(yeni_sehir);
            }

            oku.Close();
            bag.Close();
            return sehir_listesi;

        }
    }
}