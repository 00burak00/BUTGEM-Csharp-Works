using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace Veritabani_uygulamasi
{

    public class Urundao
    {
        SqlConnection bag = new Connection_yapici().baglantiya_gec();
        SqlCommand cmd = new SqlCommand();

        public int son_urun_id_getir()
        {
            int son_urunid;
            bag.Open();
            cmd.CommandText = "Select max(urunid) from urunler";
            cmd.Connection = bag;
            son_urunid = Convert.ToInt32(cmd.ExecuteScalar());

            bag.Close();
            return son_urunid;
        }

        public int urun_kaydet(Urun urunum)
        {

            int sayi = 0;
            try
            {
                bag.Open();
                cmd.CommandText = "insert into urunler (urunadi,fiyat,aciklama,resim,kateno) values (" +
                    "@urunadi,@fiyat,@aciklama,@resim,@kateno)";
                cmd.Connection = bag;
                cmd.Parameters.AddWithValue("@urunadi", urunum.Urunadi);
                cmd.Parameters.AddWithValue("@fiyat", urunum.Fiyat);
                cmd.Parameters.AddWithValue("@aciklama", urunum.Aciklama);
                cmd.Parameters.AddWithValue("@resim", urunum.Resim);
                cmd.Parameters.AddWithValue("@kateno", urunum.Kateno.Kateno);
                sayi = cmd.ExecuteNonQuery();


                bag.Close();
            }
            catch (SqlException) { sayi = -1; }
            catch (Exception) { sayi = -2; }
            return sayi;

        }

        public ArrayList sayfali_urun_getir(int kateno,int baslangic_yeri)
        {
            ArrayList urunler = new ArrayList();
            bag.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from urunler where kateno=@kateno", bag);
            adaptor.SelectCommand.Parameters.AddWithValue("@kateno", kateno);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, baslangic_yeri, 9, "urunler");
            foreach (DataRow satir in ds.Tables["urunler"].Rows)
            {
                Urun yeni_urun = new Urun()
                {
                    Urunid=Convert.ToInt32(satir["urunid"]),
                    Urunadi =satir["urunadi"].ToString (),
                    Aciklama= satir["aciklama"].ToString(),
                    Fiyat =Convert.ToDouble(satir["fiyat"]),
                    Resim= satir["resim"].ToString(),
                };
                urunler.Add(yeni_urun);
            }

            return urunler;

            bag.Close();
        }

        public int toplam_urunsayisi(int kateno)
        {
            bag.Open();
            cmd.CommandText = "select count(*) from urunler where kateno=@kateno";
            cmd.Parameters.AddWithValue("@kateno", kateno);
            cmd.Connection = bag;
           int sayi=Convert.ToInt32( cmd.ExecuteScalar());

            bag.Close();
            return sayi;
        }

        public Urun tek_urun_getir(int urunid)
        {
            bag.Open();
            cmd.CommandText = "select * from urunler,kategoriler where urunler.kateno=kategoriler.kateno and urunid=@urunid";
            cmd.Parameters.AddWithValue("@urunid", urunid);
            cmd.Connection = bag;
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            Kategori k = new Kategori(Convert.ToInt32(oku["kateno"]), oku["kateadi"].ToString());
            Urun urunum = new Urun()
            {
                Urunid = Convert.ToInt32(oku["urunid"]),
                Urunadi = oku["urunadi"].ToString(),
                Fiyat = Convert.ToDouble(oku["fiyat"]),
                Aciklama = oku["aciklama"].ToString(),
                Resim = oku["resim"].ToString(),
                Kateno = k

            };
            bag.Close();
            return urunum;
        }
    }
}