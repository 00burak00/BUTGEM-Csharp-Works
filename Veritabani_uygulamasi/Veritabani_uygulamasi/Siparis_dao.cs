using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
namespace Veritabani_uygulamasi
{
    public class Siparis_dao
    {
        SqlConnection baglanti = new Connection_yapici().baglantiya_gec();

        public int siparis_kaydet(int uyeid,ArrayList musteri_sepet)
        {
            baglanti.Open();
            SqlCommand cmd1 =
           new SqlCommand("select max(sipno) from siparisler", baglanti);
            int yeni_sipno = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;
            foreach (Sepetlik sepetteki_urun in musteri_sepet)
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = baglanti;
                cmd2.CommandText=("insert into siparisler (sipno,uyeid," +
                    "urunid,adet,sip_tarihi) values (@sipno,@uyeid," +
                     "@urunid,@adet,@sip_tarihi)");
                cmd2.Parameters.AddWithValue("@sipno", yeni_sipno);
                cmd2.Parameters.AddWithValue("@uyeid", uyeid);
                cmd2.Parameters.AddWithValue("@urunid", sepetteki_urun.Urunum.Urunid);
                cmd2.Parameters.AddWithValue("@adet", sepetteki_urun.Adet);
                cmd2.Parameters.AddWithValue("@sip_tarihi", Convert.ToDateTime(DateTime.Now.ToString()));
                cmd2.ExecuteNonQuery();
            }
            baglanti.Close();
            return yeni_sipno;
        }

        public DataSet siparis_raporu()
        {
            baglanti.Open();
            siparis_dataset ds = new siparis_dataset();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT *" +
                " " +
                 "FROM uyeler INNER JOIN siparisler ON uyeler.uyeid = siparisler.uyeid INNER JOIN " +
                  "urunler ON siparisler.urunid = urunler.urunid", baglanti);
            adaptor.Fill(ds, "siparis_tablosu");
            baglanti.Close();
            return ds;
        }
    }
}