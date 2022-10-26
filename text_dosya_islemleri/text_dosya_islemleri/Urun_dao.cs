using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;
namespace text_dosya_islemleri
{
    public class Urun_dao
    {
    
        
        public void urun_kaydet(urun yeni_urun)
        {
            string yol = HttpContext.Current.Server.MapPath("");
            yol += "/dosya/urunler.txt";
            StreamWriter dosya = null;
            if (File.Exists(yol) == false)
            {
                dosya = File.CreateText(yol);
                dosya.WriteLine(yeni_urun.text_veri_hazirla());
                dosya.Flush();
            }
            else// varsa
            {

                dosya = File.AppendText(yol);
                dosya.WriteLine(yeni_urun.text_veri_hazirla());
                dosya.Flush();
            }
            dosya.Close();
        }
       public ArrayList urunleri_getir()
        {
            string yol = HttpContext.Current.Server.MapPath("");
            yol += "/dosya/urunler.txt";
            StreamReader dosya = File.OpenText(yol);
            String s;
            ArrayList urun_listem = new ArrayList();
            while ((s = dosya.ReadLine()) != null)
            {
                string[] s2 = s.Split(':');
                urun ur = new urun()
                {
                    Barkod = Convert.ToInt32(s2[0]),
                    Urun_adi = s2[1],
                    Fiyat = Convert.ToInt32(s2[2]),
                    Kateno = Convert.ToInt32(s2[3]),
                };
                urun_listem.Add(ur);
            }//while

            return urun_listem;
        }

    }
}