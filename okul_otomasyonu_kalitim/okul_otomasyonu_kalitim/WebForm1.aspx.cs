using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace okul_otomasyonu_kalitim
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int kisi_sayisi = Convert.ToInt32(Interaction.InputBox("kisi sayısı girin", "", "", -1, -1));

            Kisi[] kisi_listesi = new Kisi[kisi_sayisi];
            int sayac = 0;
            for (int i=0;i<kisi_sayisi;i++)
            {
                byte secim= Convert.ToByte(Interaction.InputBox("1-Öğrenci 2-Personel", "", "", -1, -1));
                if (secim == 1)
                {
                    Ogrenci ogr = new Ogrenci();
                    ogr.Tckimlik = Convert.ToInt64(Interaction.InputBox("tckimlik girin", "", "", -1, -1));
                    ogr.Ad_soyad = Interaction.InputBox("ad girin", "", "", -1, -1);
                    ogr.Ogno = Convert.ToInt32(Interaction.InputBox("ogno girin", "", "", -1, -1));
                    ogr.Bolum_adi = Interaction.InputBox("bolum adı girin", "", "", -1, -1);
                    ogr.Adres = adres_gir();
                    kisi_listesi[i] = ogr;
                }
                else if (secim == 2)
                {
                    Personel per = new Personel();
                    per.Tckimlik = Convert.ToInt64(Interaction.InputBox("tckimlik girin", "", "", -1, -1));
                    per.Ad_soyad = Interaction.InputBox("ad girin", "", "", -1, -1);
                    per.Perno = Convert.ToInt32(Interaction.InputBox("perno girin", "", "", -1, -1));
                    per.Brans = Interaction.InputBox("branş girin", "", "", -1, -1);
                    per.Adres = adres_gir();
                    kisi_listesi[i] = per;
                }
                else Interaction.MsgBox("Yanlış seçim");
                byte cvp= Convert.ToByte(Interaction.MsgBox("devam edecekmisin?",MsgBoxStyle.YesNo));
                if(cvp==7) { sayac = i + 1;break; }
            }//for

            Array.Resize(ref kisi_listesi, sayac);

            foreach ( Kisi gelen_kisi  in kisi_listesi)
            {

              if (gelen_kisi is Ogrenci)  ListBox1.Items.Add(((Ogrenci)gelen_kisi).ogrenci_bilgisi());
              if(gelen_kisi is Personel)  ListBox1.Items.Add(((Personel)gelen_kisi).personel_bilgisi());
            }


        }//buton click

        public Adres adres_gir()
        {
            Adres adr = new Adres()
            {
                Ilce = Interaction.InputBox("ilce girin", "", "", -1, -1),
                Mahalle = Interaction.InputBox("mahalle girin", "", "", -1, -1),

            };
            return adr;
        }
    }
}