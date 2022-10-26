using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace Veritabani_uygulamasi
{
    public class Uyeler_dao
    {
        SqlConnection bag = new Connection_yapici().baglantiya_gec();
        ArrayList uye_listem;
        SqlCommand cmd = new SqlCommand();
        public ArrayList uyeler_all_list()
        {
            string sql = "select * from uyeler,meslek,sehirler " +
    "where uyeler.meslekid=meslek.meslekid and uyeler.plaka=sehirler.plaka order by adsoyad";
            cmd.CommandText = sql;
            uye_listem = liste_yaz();
            return uye_listem;
        }

    


        public Uye uye_giris_kontrol(String kuladi,String sifre)//hemde uye duzenle kullancam
        {
            Uye uyem=null;
            try
            {
                bag.Open();

                cmd.Connection = bag;
                string sql = "select* from uyeler,meslek,sehirler " +
    "where uyeler.meslekid=meslek.meslekid and uyeler.plaka=sehirler.plaka and "+
    "kuladi=@kuladi and sifre=@sifre";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kuladi", kuladi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                SqlDataReader oku = cmd.ExecuteReader();
                oku.Read();
                Meslek mes = new Meslek(
                Convert.ToInt32(oku["meslekid"]), oku["meslekad"].ToString());

                Sehir seh = new Sehir(Convert.ToByte(oku["plaka"]), oku["sehiradi"].ToString());
                uyem = new Uye()
                {
                    Uyeid = Convert.ToInt32(oku["uyeid"]),
                    Adsoyad = oku["adsoyad"].ToString(),
                    Kuladi = oku["kuladi"].ToString(),
                    Sifre = oku["sifre"].ToString(),
                    Dogtar = Convert.ToDateTime(oku["dogtar"]),
                    Adres = oku["adres"].ToString(),
                    Email = oku["email"].ToString(),
                    Cinsiyet = Convert.ToBoolean(oku["cinsiyet"]),
                    Sehir=seh,
                    Meslek =mes
                };

                bag.Close();
            }
            catch (Exception)
            {

            }
                 return uyem;
        }


        public ArrayList uye_filtrele(String email,int plaka)
        {
            string sql = "";
            if (plaka != 0)
            {
                sql = "select * from uyeler,meslek,sehirler " +
      "where uyeler.meslekid=meslek.meslekid and uyeler.plaka=sehirler.plaka" +
      " and uyeler.plaka=@plaka order by adsoyad";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@plaka", plaka);
            }
            else
            {
                sql = "select * from uyeler,meslek,sehirler " +
    "where uyeler.meslekid=meslek.meslekid and uyeler.plaka=sehirler.plaka" +
    " and email like '%@email' order by adsoyad";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@email", email);
            }
           uye_listem = liste_yaz();
            return uye_listem;
        }



        public ArrayList liste_yaz()
        {
            uye_listem = new ArrayList();
            bag.Open();

            cmd.Connection = bag;
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                Meslek mes = new Meslek(
             Convert.ToInt32(oku["meslekid"]), oku["meslekad"].ToString());

                Sehir seh = new Sehir(Convert.ToByte(oku["plaka"]), oku["sehiradi"].ToString());

                Uye yeni_uye = new Uye()
                {
                    Uyeid = Convert.ToInt32(oku["uyeid"]),
                    Kuladi = oku["kuladi"].ToString(),
                    Sifre = oku["sifre"].ToString(),
                    Adsoyad = oku["adsoyad"].ToString(),
                    Dogtar = Convert.ToDateTime(oku["dogtar"]),
                    Adres = oku["adres"].ToString(),
                    Email = oku["email"].ToString(),
                    Cinsiyet = Convert.ToBoolean(oku["cinsiyet"]),
                    Sehir = seh,
                    Meslek = mes,
                };
                if (oku["onay"] is DBNull)
                    yeni_uye.Onay = false;
                else yeni_uye.Onay = Convert.ToBoolean(oku["onay"]);
                uye_listem.Add(yeni_uye);
            }//while
            oku.Close();

            bag.Close();
            return uye_listem;




        }

        public int uye_kaydet(string kuladi,string sifre,string adsoyad,
            DateTime dogtar,bool cinsiyet,string adres,int plaka,string email,
            int meslekid)
        {
            sayac = 0;
            oneri_listesi.Clear();
            int sayi = 0;
            try
            {
                bag.Open();
                cmd.Connection = bag;
                cmd.CommandText = "insert into uyeler (kuladi,sifre,adsoyad,dogtar," +
                    "cinsiyet,adres,plaka,email,meslekid) values" +
                    " (@kuladi,@sifre,@adsoyad,@dogtar," +
                    "@cinsiyet,@adres,@plaka,@email,@meslekid)";
                cmd.Parameters.AddWithValue("@kuladi", kuladi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                cmd.Parameters.AddWithValue("@dogtar", dogtar);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@meslekid", meslekid);
                sayi = cmd.ExecuteNonQuery();
            }
            catch (SqlException hata)
            {
                
                int bilgi = hata.Message.IndexOf("uk_email");
                if (bilgi != -1) //demekki email hatası vermiş
                    sayi = -1;
                else
                    sayi = -2;//kuladi hatası vermiş
            }
            catch (Exception) { sayi = -3; }

           finally
            { bag.Close(); }
           
            return sayi;
        }


        public int uye_guncelle(string kuladi, string sifre, string adsoyad,
           DateTime dogtar, bool cinsiyet, string adres, int plaka, string email,
           int meslekid,int uyeid)
        {
            sayac = 0;
            oneri_listesi.Clear();
            int sayi = 0;
            try
            {
                bag.Open();
                cmd.Connection = bag;
                cmd.CommandText = "update uyeler set kuladi=@kuladi,sifre=@sifre,adsoyad=@adsoyad,dogtar=@dogtar,"+
                    "cinsiyet=@cinsiyet,adres=@adres,email=@email,plaka=@plaka,meslekid=@meslekid where uyeid=@uyeid";
                cmd.Parameters.AddWithValue("@kuladi", kuladi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                cmd.Parameters.AddWithValue("@dogtar", dogtar);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@meslekid", meslekid);
                cmd.Parameters.AddWithValue("@uyeid", uyeid);
                sayi = cmd.ExecuteNonQuery();
            }
            catch (SqlException hata)
            {

                int bilgi = hata.Message.IndexOf("uk_email");
                if (bilgi != -1) //demekki email hatası vermiş
                    sayi = -1;
                else
                    sayi = -2;//kuladi hatası vermiş
            }
            catch (Exception) { sayi = -3; }

            finally
            { bag.Close(); }

            return sayi;
        }

        public int uye_sil(int uyeid)
        {
            int sayi = 0;
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "delete from uyeler where uyeid=@uyeid";
            cmd.Parameters.AddWithValue("@uyeid", uyeid);
            sayi= cmd.ExecuteNonQuery();


            bag.Close();
            return sayi;
        }




        public static ArrayList oneri_listesi = new ArrayList();
        public static int sayac = 0;
        public static void kullanici_adi_oner(string kuladi)
        {
            System.Threading.Thread.Sleep(200);
            String[] harfler = { "a", "b", "c", "z", "e" };
            Random uret = new Random();
            int rakam = uret.Next(1, 9);
            string harf = harfler[uret.Next(0, 4)];
            string yeni_kuladi = kuladi + rakam + harf;
            SqlConnection baglanti = new Connection_yapici().baglantiya_gec();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from uyeler where kuladi=@kuladi", baglanti);
            komut.Parameters.AddWithValue("@kuladi", yeni_kuladi);

            int sayi =Convert.ToInt32( komut.ExecuteScalar().ToString());
            if (sayi == 0)//demekki benim önermek için bulduğum yeni_kuladi yok.listeye ekle
            {
                oneri_listesi.Add(yeni_kuladi);
                sayac++;
            }
            baglanti.Close();
           if (sayac!=5) kullanici_adi_oner(kuladi);
        }

        public DataSet uye_raporla()
        {
          
            bag.Open();
            uyeler_dataseti ds = new uyeler_dataseti();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from uyeler order by adsoyad asc", bag);
            adaptor.Fill(ds, "uyeler");
            bag.Close();
            return ds;
        }
    }
}